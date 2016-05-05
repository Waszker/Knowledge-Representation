using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using KR.Main.Entities;
using KR.Main.Entities.Conditions;
using KR.Main.Entities.Statements;
using Action = KR.Main.Entities.Action;

namespace KR.Main.Engine
{
    sealed partial class World : World.IRes
    {
        #region Singleton

        private static readonly Lazy<World> instance = new Lazy<World>(() => new World());
        public static World Instance => instance.Value;

        #endregion


        private List<Fluent> _fluents;
        private List<Actor> _actors;
        private List<Action> _actions;
        private Domain _domain;

        private List<State> _states;
        private State _initialState;


        #region Constructors and building methods

        private World() {}

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

        private List<State> GetResZero(List<State> validStates, Action action, Actor actor, State from)
        {
            List<State> resZero = new List<State>(validStates);
            bool clauseFound = false;

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
                resZero = resZero.FindAll(s => causesClause.Effect.Check(s));
            }

            // No clauses were found so the action has no effect.
            if (!clauseFound)
                resZero = new List<State> { from };

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

                resZero.RemoveAll(s => impossibleClause.Condition.Check(s));
            }
            
            return resZero;
        }

        private List<State> GetResMinus(List<State> resZero, Action action, Actor actor, State from)
        {
            List<State> resMinus = new List<State>();

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

        private List<State> GetResZeroPlus(List<State> resZero, Action action, Actor actor, State from)
        {
            List<State> resZeroPlus = new List<State>(resZero);

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

                resZeroPlus = resZeroPlus.FindAll(s => tCausesClause.Effect.Check(s));
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





        //TODO

        public List<State> GetAllStates(ICondition condition)
        {
            throw new NotImplementedException();
        }

        public List<Edge> GetAllEdges(State fromState = null)
        {
            throw new NotImplementedException();
        }

        public ICollection<State> GetStates(bool abnormal, Action action, Actor actor, State state)
        {
            throw new NotImplementedException();
        }
        
    }
}
