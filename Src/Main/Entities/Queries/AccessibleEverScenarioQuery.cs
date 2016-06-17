using KR.Main.Engine;
using KR.Main.Entities.Conditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Main.Entities.Queries
{
    public class AccessibleEverScenarioQuery : Query
    {
        private ICondition gamma;
        private ICondition pi;
        private Scenario scenario;

        public AccessibleEverScenarioQuery(ICondition pi, ICondition gamma, Scenario scenario)
        {
            this.pi = pi;
            this.gamma = gamma;
            this.scenario = scenario;
        }
        public override bool Evaluate(World world, List<Edge> edges = null)
        {
            return world.GetStates(pi).Any(s => Accessible(s, world));
        }

        private bool Accessible(State startState, World world)
        {
            var states = new List<State>() { startState };
            foreach (var step in scenario)
            {
                states = states.SelectMany(s => world.GetEdges(s)
                .Where(e => e.Action.Equals(step.Action) && e.Actor.Equals(step.Actor)).Select(e => e.To)).ToList();
                if (states.Count == 0) return false;
            }
            return states.All(s => Accessible(world, s));
        }

        private bool Accessible(World world, State state)
        {
            var open = new HashSet<State>(world.GetEdges(state).Select(edge => edge.To));
            var close = new HashSet<State>();
            while (open.Count > 0)
            {
                var state2 = open.First();
                if (gamma.Check(state2)) return true;
                open.Remove(state2);
                close.Add(state2);
                foreach (var state3 in world.GetEdges(state2).Select(edge => edge.To).Distinct())
                {
                    if (!close.Contains(state3)) open.Add(state3);
                }
            }
            return false;
        }
    }
}