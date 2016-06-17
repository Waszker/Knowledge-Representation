using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KR.Main.Engine;
using KR.Main.Entities.Conditions;

namespace KR.Main.Entities.Queries
{
    public class AccessibleAlwaysScenarioQuery : Query
    {
        private ICondition gamma;
        private ICondition pi;
        private Scenario scenario;

        public AccessibleAlwaysScenarioQuery(ICondition pi, ICondition gamma, Scenario scenario)
        {
            this.pi = pi;
            this.gamma = gamma;
            this.scenario = scenario;
        }
        public override bool Evaluate(World world, List<Edge> edges = null)
        {
            return world.GetStates(pi).All(s => AccessibleScenario(world, s));
        }

        private bool AccessibleScenario(World world, State startState)
        {
            var states = new List<State>() { startState };
            foreach (var step in scenario)
            {
                states = states.SelectMany(s => world.GetEdges(s)
                .Where(e => e.Action.Equals(step.Action) && e.Actor.Equals(step.Actor)).Select(e => e.To)).ToList();
            }
            //if (states.Count == 0) return false;
            var query = new AccessibleAlwaysQuery(null, gamma);
            return query.Evaluate2(world, states);
        }

        private bool Accessible(World world, List<State> states)
        {
            var open = new HashSet<State>(states.SelectMany(state => world.GetEdges(state).Select(edge => edge.To)));
            var close = new HashSet<State>();
            while (open.Count > 0)
            {
                var state = open.First();
                open.Remove(state);
                close.Add(state);
                foreach (var state2 in world.GetEdges(state).Select(edge => edge.To))
                {
                    if (!close.Contains(state2)) open.Add(state2);
                }
            }
            return close.All(state => gamma.Check(state));
        }
    }
}
