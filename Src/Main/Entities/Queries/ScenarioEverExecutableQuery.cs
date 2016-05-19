using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KR.Main.Engine;

namespace KR.Main.Entities.Queries
{
    public class ScenarioEverExecutableQuery : ScenarioExecutableQuery
    {
        public ScenarioEverExecutableQuery(Scenario scenario) : base(scenario) { }

        public override bool Evaluate(World world, List<Edge> edges = null)
        {
            ISet<State> possibleStates = world.GetStates();

            foreach (ScenarioStep step in Scenario.Steps)
            {
                ISet<State> newPossibleStates = new HashSet<State>();
                foreach (State state in possibleStates)
                {
                    IEnumerable<Edge> edgesForStep = EdgesForStep(world, state, step);
                    // add new possible result states
                    foreach (Edge edge in edgesForStep)
                    {
                        newPossibleStates.Add(edge.To);
                    }
                }
                if (newPossibleStates.Count == 0)
                {
                    // no new states possible - scenario is never executable
                    return false;
                }
                // replace possible state sets - next iteration
                possibleStates = newPossibleStates;
            }
            // all steps executed - scenario is executable
            return true;
        }
    }
}
