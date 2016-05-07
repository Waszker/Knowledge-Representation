using System;
using System.Collections.Generic;
using System.Linq;
using KR.Main.Entities;
using KR.Main.Entities.Conditions;
using Action = KR.Main.Entities.Action;

namespace KR.Main.Engine
{
    public sealed partial class World
    {
        #region Singleton

        private static readonly Lazy<World> _instance = new Lazy<World>(() => new World());
        public static World Instance => _instance.Value;

        #endregion

        private List<Fluent> _fluents;
        private List<Actor> _actors;
        private List<Action> _actions;
        private Domain _domain;

        private List<State> _states;
        private State _initialState;

        private readonly Dictionary<int, ISet<State>> _resNCache;
        private readonly Dictionary<int, ISet<State>> _resAbCache;

        private Graph _graph;

        #region Constructors and building methods

        private World()
        {
            _resNCache = new Dictionary<int, ISet<State>>();
            _resAbCache = new Dictionary<int, ISet<State>>();
        }

        public void SetActions(List<Entities.Action> actions)
        {
            _actions = actions;
        }

        public void SetActors(List<Actor> actors)
        {
            _actors = actors;
        }

        public void SetFluents(List<Fluent> fluents)
        {
            _fluents = fluents;
        }

        public void SetDomain(Domain domain)
        {
            _domain = domain;
        }

        public bool Build()
        {
            if (_actions == null || _actors == null || _fluents == null || _domain == null)
                return false;

            _states = GenerateAllValidStates();
            _initialState = GetInitialState();

            _resNCache.Clear();
            _resAbCache.Clear();

            _graph = new Graph(_actions, _actors, _states);
            return true;
        }

        #endregion


        #region Generating valid states

        private List<State> GenerateAllValidStates()
        {
            List<State> allStates = new List<State>();
            BackTrack(allStates, new List<bool>(_fluents.Count), _fluents.Count, 0);
            List<State> validStates = new List<State>();

            // Filter out invalid states.
            foreach (var state in allStates)
            {
                bool isValid = true;
                foreach (var clause in _domain.AlwaysClauses)
                {
                    if (!clause.Condition.Check(state))
                    {
                        isValid = false;
                        break;
                    }
                }
                if (isValid)
                    validStates.Add(state);
            }

            return validStates;
        }

        private void BackTrack(List<State> allStates, List<bool> buffer, int n, int k)
        {
            if (k == n)
                allStates.Add(new State(_fluents, buffer));
            else
            {
                buffer.Add(true);
                BackTrack(allStates, buffer, n, k + 1);
                buffer.RemoveAt(buffer.Count - 1);
                buffer.Add(false);
                BackTrack(allStates, buffer, n, k + 1);
                buffer.RemoveAt(buffer.Count - 1);
            }
        }

        #endregion

        private State GetInitialState()
        {
            State initialState = null;
            foreach (var state in _states)
            {
                bool isInitial = true;
                foreach (var clause in _domain.InitiallyClauses)
                {
                    if (!clause.Condition.Check(state))
                    {
                        isInitial = false;
                        break;
                    }
                }
                if (isInitial)
                {
                    if (initialState == null)
                        initialState = state;
                    else
                        throw new InvalidOperationException("Stan początkowy musi być dokładnie jeden.");
                }

            }
            return initialState;
        }


        #region Res and New sets

        private HashSet<State> GetResZero(List<State> validStates, Action action, Actor actor, State from)
        {
            HashSet<State> resZero = new HashSet<State>(validStates);
            bool clauseFound = false;

            foreach (var impossibleClause in _domain.ImpossibleClauses)
            {
                if (impossibleClause.Action != action)
                    continue;
                if (!impossibleClause.Exclusion && !_actors.Contains(actor))
                    continue;
                if (impossibleClause.Exclusion && !_actors.Except(impossibleClause.Actors).Contains(actor))
                    continue;
                if (!impossibleClause.Condition.Check(from))
                    continue;

                resZero.Clear();
                return resZero;
            }

            foreach (var causesClause in _domain.CausesClauses)
            {
                if (causesClause.Action != action)
                    continue;
                if (!causesClause.Exclusion && !_actors.Contains(actor))
                    continue;
                if (causesClause.Exclusion && !_actors.Except(causesClause.Actors).Contains(actor))
                    continue;
                if (!causesClause.Condition.Check(from))
                    continue;

                clauseFound = true;

                resZero.RemoveWhere(s => !causesClause.Effect.Check(s));
            }

            // No clauses were found so the action has no effect.
            if (!clauseFound)
                resZero = new HashSet<State> { from };

            foreach (var preservesClause in _domain.PreservesClauses)
            {
                if (preservesClause.Action != action)
                    continue;
                if (!preservesClause.Exclusion && !_actors.Contains(actor))
                    continue;
                if (preservesClause.Exclusion && !_actors.Except(preservesClause.Actors).Contains(actor))
                    continue;
                if (!preservesClause.Condition.Check(from))
                    continue;

                var fluent = preservesClause.Fluent;
                resZero.RemoveWhere(s => s[fluent] != from[fluent]);
            }

            return resZero;
        }

        private HashSet<State> GetResMinus(HashSet<State> resZero, Action action, Actor actor, State from)
        {
            HashSet<State> resMinus = new HashSet<State>();

            int minNewSize = int.MaxValue;
            foreach (var to in resZero)
            {
                var newSet = GetNew(action, actor, from, to);

                if (newSet.Count > minNewSize)
                    continue;
                else if (newSet.Count == minNewSize)
                    resMinus.Add(to);
                else
                {
                    resMinus.Clear();
                    minNewSize = newSet.Count;
                    resMinus.Add(to);
                }
            }

            return resMinus;
        }

        private HashSet<State> GetResZeroPlus(HashSet<State> resZero, Action action, Actor actor, State from)
        {
            HashSet<State> resZeroPlus = new HashSet<State>(resZero);

            foreach (var tCausesClause in _domain.TypicallyCausesClauses)
            {
                if (tCausesClause.Action != action)
                    continue;
                if (!tCausesClause.Exclusion && !_actors.Contains(actor))
                    continue;
                if (tCausesClause.Exclusion && !_actors.Except(tCausesClause.Actors).Contains(actor))
                    continue;
                if (!tCausesClause.Condition.Check(from))
                    continue;

                resZeroPlus.RemoveWhere(s => !tCausesClause.Effect.Check(s));
            }

            return resZeroPlus;
        }

        private HashSet<Fluent> GetNew(Action action, Actor actor, State from, State to)
        {
            HashSet<Fluent> newSet = new HashSet<Fluent>();

            foreach (var fluent in _fluents)
            {
                if (from[fluent] != to[fluent])
                    newSet.Add(fluent);
            }

            foreach (var releaseClause in _domain.ReleasesClauses)
            {
                if (releaseClause.Action != action)
                    continue;
                if (!releaseClause.Exclusion && !_actors.Contains(actor))
                    continue;
                if (releaseClause.Exclusion && !_actors.Except(releaseClause.Actors).Contains(actor))
                    continue;
                if (!releaseClause.Condition.Check(from))
                    continue;

                newSet.Add(releaseClause.Fluent);
            }

            return newSet;
        }

        private HashSet<State> GetResN(HashSet<State> resZeroPlus, Action action, Actor actor, State from)
        {
            HashSet<State> resN = new HashSet<State>();

            int minNewSize = int.MaxValue;
            foreach (var to in resZeroPlus)
            {
                var newSet = GetNew(action, actor, from, to);

                if (newSet.Count > minNewSize)
                    continue;
                else if (newSet.Count == minNewSize)
                    resN.Add(to);
                else
                {
                    resN.Clear();
                    minNewSize = newSet.Count;
                    resN.Add(to);
                }
            }
            return resN;
        }

        private HashSet<State> GetResAb(HashSet<State> resMinus, HashSet<State> resN)
        {
            return new HashSet<State>(resMinus.Except(resN));
        }

        #endregion




        public List<Edge> GetEdges(State from = null)
        {
            return _graph.GetEdges(from);
        }

        public ISet<State> GetStates(ICondition condition = null)
        {
            if (condition == null)
                return new HashSet<State>(_states);
            return new HashSet<State>(_states.Where(condition.Check));
        }

        public ISet<State> GetStates(Action action, Actor actor, State from, bool abnormal)
        {
            int keyHash = new { action, actor, from }.GetHashCode();

            if (abnormal && _resAbCache.ContainsKey(keyHash))
                return _resAbCache[keyHash];
            if (!abnormal && _resNCache.ContainsKey(keyHash))
                return _resNCache[keyHash];

            // Calculating Res sets for every method invocation is expensive. Not sure if there's better way tho.

            var resZero = GetResZero(_states, action, actor, from);
            var resMinus = GetResMinus(resZero, action, actor, from);
            var resZeroPlus = GetResZeroPlus(resZero, action, actor, from);
            var resN = GetResN(resZeroPlus, action, actor, from);
            var resAb = GetResAb(resMinus, resN); // Calculating ResAb is cheap when ResN is given.

            _resNCache.Add(keyHash, resN);
            _resAbCache.Add(keyHash, resAb);

            return abnormal ? resAb : resN;
        }

    }
}
