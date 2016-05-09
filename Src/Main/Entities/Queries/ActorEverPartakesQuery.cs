using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KR.Main.Engine;

namespace KR.Main.Entities.Queries
{
    public class ActorEverPartakesQuery : ActorPartakesQuery
    {
        public ActorEverPartakesQuery(Actor actor, Scenario scenario) : base(actor, scenario) { }

        public override bool Evaluate(World world)
        {
            ISet<State> possibleStates = world.GetStates();

            foreach (ScenarioStep step in Scenario.Steps)
            {
                ISet<State> newPossibleStates = new HashSet<State>();
                foreach (State state in possibleStates)
                {
                    IEnumerable<Edge> edgesForStep = EdgesForStep(world, state, step);

                    foreach (Edge edge in edgesForStep)
                    {
                        // check, if actor partakes
                        if (edge.Actor.Equals(this.Actor))
                        {
                            return true;
                        }
                        newPossibleStates.Add(edge.To);
                    }
                }
                possibleStates = newPossibleStates;
            }
            // after checking all steps no matching actor found - never partakes
            return false;
        }
    }
}
