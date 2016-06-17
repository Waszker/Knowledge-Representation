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
                if (states.Count == 0) return false;
            }

            var query = new AccessibleAlwaysQuery(null, gamma, states);
            return query.Evaluate(world);
        }
    }
}
