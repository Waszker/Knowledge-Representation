using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KR.Main.Engine;

namespace KR.Main.Entities.Queries
{
    public class ActorAlwaysPartakesQuery : ActorPartakesQuery
    {
        public ActorAlwaysPartakesQuery(Actor actor, Scenario scenario) : base(actor, scenario) { }

        public override bool Evaluate(World world, List<Edge> edges = null)
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
                            ; // dont continue this path - actor found
                        }
                        else
                        {
                            // continue path to find actor
                            newPossibleStates.Add(edge.To);
                        }
                    }
                }
                if(newPossibleStates.Count == 0)
                {
                    // all paths contained the actor - ok ('end of search' condition)
                    return true;
                    // TODO: unexecutable scenarios?
                }
                possibleStates = newPossibleStates;
            }
            // 'end of search' condition not satisfied
            return false;
        }
    }
}
