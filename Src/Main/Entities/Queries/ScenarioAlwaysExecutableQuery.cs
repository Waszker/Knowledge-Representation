using KR.Main.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Main.Entities.Queries
{
    public class ScenarioAlwaysExecutableQuery : ScenarioExecutableQuery
    {
        public ScenarioAlwaysExecutableQuery(Scenario scenario) : base(scenario) { }

        public override bool Evaluate(World world)
        {
            ISet<State> possibleStates = world.GetStates();

            foreach (ScenarioStep step in Scenario.Steps)
            {
                ISet<State> newPossibleStates = new HashSet<State>();
                foreach (State state in possibleStates)
                {
                    IEnumerable<Edge> edgesForStep = EdgesForStep(world, state, step);
                    if (edgesForStep.Count() == 0)
                    {
                        // scenario is not executable - no possible edges
                        return false;
                    }
                    // add new possible result states
                    foreach (Edge edge in edgesForStep)
                    {
                        newPossibleStates.Add(edge.To);
                    }
                }
                // replace possible state sets - next iteration
                possibleStates = newPossibleStates;
            }
            // all steps executed - scenario is executable
            return true;
        }
    }
}
