using System;
using System.Collections.Generic;
using KR.Main.Entities;
using System.Linq;
using KR.Main.Entities.Conditions;
using Action = KR.Main.Entities.Action;

namespace KR.Main.Builders
{
    class WorldBuilder : IWorldBuilder
    {
        private static readonly Lazy<WorldBuilder> instance = new Lazy<WorldBuilder>(() => new WorldBuilder());
        public static WorldBuilder Instance => instance.Value;

        private List<Fluent> _fluents;
        private List<Action> _actions;
        private List<Actor> _actors;
        private Domain _domain;

        List<State> _states = new List<State>();
        private List<Transition> _transitionsAbnormal = new List<Transition>();
        private List<Transition> _transitionsNormal = new List<Transition>();
        private List<Transition> _transitionsReleased = new List<Transition>();
        private List<Transition> _transitionsImpossible = new List<Transition>();
        State _initialState;
        private WorldBuilder() { }

        class Transition
        {
            public State StartState;
            public State EndState;
            public Actor Actor;
            public Action Action;
            public Transition(Actor actor, Action action, State startState, State endState)
            {
                StartState = startState;
                EndState = endState;
                Actor = actor;
                Action = action;
            }
            public Transition()
            {

            }
        }

        public World Build()
        {
            Validate();

            ProcessAlways();

            //od teraz _states odpowiadają wierzchołkom grafu
            ProcessInitially();
            //mamy już wyznaczony stan początkowy

            //pozostaje wyznaczyć przejścia na podstawie zdań causes, typically causes i preserves

            PrepareResAbResN();//TODO

            ProcessReleases();

            ProcessImpossible();

            //teraz trzeba zbudować graf - mamy już wszystko co jest potrzebne

            return new World ();
        }

        private void PrepareResAbResN()
        {
            throw new NotImplementedException();
        }

        private void ProcessInitially()
        {
            List<State> initialStates = _states;
            foreach (var clause in _domain.AlwaysClauses)
                initialStates = SatisfactionGenerator.Satisfy(clause.Condition, initialStates).ToList();
            if (initialStates.Count != 1)
                throw new InvalidOperationException("Stan początkowy musi być dokładnie jeden.");
            _initialState = initialStates.Single();
        }

        private void ProcessAlways()
        {
            List<State> states = StatesGenerator.GenerateAll(_fluents).ToList();
            foreach (var clause in _domain.AlwaysClauses)
                states = SatisfactionGenerator.Satisfy(clause.Condition, states).ToList();
            _states = states;
        }

        private void ProcessReleases()
        {
            //releases:
            foreach (var clause in _domain.ReleasesClauses)//typically czy nie?
            {
                var actors = clause.Exclusion ? _actors.Except(clause.Actors) : clause.Actors;
                var startStates = SatisfactionGenerator.Satisfy(clause.Condition, _states).ToList();
                foreach (var actor in actors)
                    foreach (var startState in startStates)
                        foreach (var endState in _states.Where(s =>
                        {
                            foreach (var f in _fluents.Where(f => f != clause.Fluent))
                                if (s.Values[f] != startState.Values[f])
                                    return false;
                            return true;
                        }))
                            _transitionsReleased.Add(new Transition { Action = clause.Action, Actor = actor, StartState = startState, EndState = endState });
            }
        }

        private void ProcessImpossible()
        {
            //ograniczeie przejść przez impossible
            foreach (var clause in _domain.ImpossibleClauses)
            {
                var actors = clause.Exclusion ? _actors.Except(clause.Actors) : clause.Actors;
                foreach (var actor in actors)
                {
                    var startStates = SatisfactionGenerator.Satisfy(clause.Condition, _states).ToList();
                    foreach (var startState in startStates)
                        foreach (var endState in _states)
                            _transitionsImpossible.Add(new Transition(actor, clause.Action, startState, endState));
                }
            }
        }

        private void Validate()
        {
            if (_fluents == null)
                throw new InvalidOperationException("Podaj fluenty.");
            if (_actors == null)
                throw new InvalidOperationException("Podaj aktorów.");
            if (_actions == null)
                throw new InvalidOperationException("Podaj akcje.");
            if (_domain == null)
                throw new InvalidOperationException("Podaj domenę.");
            //sprawdzić, czy zdania domeny są wystarczające ValidateDomain();
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

        private static class SatisfactionGenerator
        {
            public static IEnumerable<State> Satisfy(ICondition cond, IEnumerable<State> states)
            {
                foreach (var item in states)
                {
                    if (cond.Check(item))
                    {
                        //Console.WriteLine(string.Join(" ", item.Select(bb => bb ? 0 : 1)));
                        yield return item;
                    }
                }
            }
        }
        private static class StatesGenerator
        {
            private static List<bool> _buf;
            private static List<List<bool>> _result;

            public static ICollection<State> GenerateAll(ICollection<Fluent> fluents)
            {
                BackTrack(fluents.Count);
                return (ICollection<State>) _result.Select(s =>
                {
                    State state = new State();
                    int i = 0;
                    foreach (var f in fluents)
                    {
                        state.Values.Add(f, s[i]);
                        i++;
                    }
                    return state;
                });
            }
            private static void BackTrack(int n, int k = 0)
            {
                if (k == n) { _result.Add(_buf); return; }
                _buf.Add(true);
                BackTrack(n, k + 1);
                _buf.RemoveAt(_buf.Count - 1);
                _buf.Add(false);
                BackTrack(n, k + 1);
                _buf.RemoveAt(_buf.Count - 1);
            }
        }
    }
}
