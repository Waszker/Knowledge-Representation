using KR.Main.Engine;
using KR.Main.Entities.Conditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Main.Entities.Queries
{
    public class AfterScenarioTypicallyQuery : Query
    {
        private ICondition gamma;
        private ICondition pi;
        private Scenario scenario;

        public AfterScenarioTypicallyQuery(ICondition pi, ICondition gamma, Scenario scenario)
        {
            this.pi = pi;
            this.gamma = gamma;
            this.scenario = scenario;
        }
        public override bool Evaluate(World world, List<Edge> edges = null)
        {
            return world.GetStates(pi).All(s => AccessibleEver(world, s));
        }

        private bool AccessibleEver(World world, State startState)
        {
            var states = new List<State>() { startState };
            foreach (var step in scenario)
            {
                states = states.SelectMany(s => world.GetEdges(s)
                .Where(e => e.Action.Equals(step.Action) && e.Actor.Equals(step.Actor) && !e.Abnormal).Select(e => e.To)).ToList();
            }
            // if (states.Count == 0) return false;
            return states.All(s => gamma.Check(s));
        }
    }
}
