using System;
using System.Collections.Generic;
using KR.Main.Entities;
using System.Linq;
using KR.Main.Entities.Conditions;

namespace KR.Main.Builders
{
    class WorldBuilder : IWorldBuilder
    {
        private static readonly Lazy<WorldBuilder> instance = new Lazy<WorldBuilder>(() => new WorldBuilder());
        public static WorldBuilder Instance => instance.Value;

        private List<Fluent> _fluents;
        private Domain _domain;
        private WorldBuilder() { }

        public World Build()
        {
            Validate();
            World world = new World();
            List<State> states = StatesGenerator.GenerateAll(_fluents).ToList();
            foreach (var clause in _domain.AlwaysClauses)
                states = SatisfactionGenerator.Satisfy(clause.Condition, states).ToList();

            //od teraz _states odpowiadają wierzchołkom grafu
            world.States = states;
            List<State> initialStates = states;
            foreach (var clause in _domain.AlwaysClauses)
                initialStates = SatisfactionGenerator.Satisfy(clause.Condition, initialStates).ToList();
            if (initialStates.Count() != 1)
                throw new InvalidOperationException("Stan początkowy musi być dokładnie jeden.");
            world.InitialState = initialStates.Single();
            //mamy już wyznaczony stan początkowy

            //pozostaje wyznaczyć przejścia na podstawie zdań causes, typically causes i preserves

            return world;
        }

        private void Validate()
        {
            if (_fluents == null)
                throw new InvalidOperationException("Podaj fluenty.");
            if (_domain == null)
                throw new InvalidOperationException("Podaj domenę.");
            //sprawdzić, czy zdania domeny są wystarczające
        }

        public void SetActions(List<Entities.Action> actions)
        {
            throw new NotImplementedException();
        }

        public void SetActors(List<Actor> actors)
        {
            throw new NotImplementedException();
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

            public static IEnumerable<State> GenerateAll(IEnumerable<Fluent> fluents)
            {
                BackTrack(fluents.Count());
                return _result.Select(s =>
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
