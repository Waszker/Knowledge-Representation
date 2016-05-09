using KR.Main.Engine;
using KR.Main.Entities.Conditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Main.Entities.Queries
{
    public class AccessibleTypicallyScenarioQuery : Query
    {
        private ICondition gamma;
        private ICondition pi;
        private Scenario scenario;

        public AccessibleTypicallyScenarioQuery(ICondition pi, ICondition gamma, Scenario scenario)
        {
            this.pi = pi;
            this.gamma = gamma;
            this.scenario = scenario;
        }
        public override bool Evaluate(World world)
        {
            return world.GetStates(pi).Any(s => Accessible(s, world));
        }

        private bool Accessible(State startState, World world)
        {
            var states = new List<State>() { startState };
            foreach (var step in scenario)
            {
                states = states.SelectMany(s => world.GetEdges(s)
                .Where(e => !e.Abnormal && e.Action.Equals(step.Action) && e.Actor.Equals(step.Actor)).Select(e => e.To)).ToList();
            }
            return states.All(s => gamma.Check(s));
        }
    }
}