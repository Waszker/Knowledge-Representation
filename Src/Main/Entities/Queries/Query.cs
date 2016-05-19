using KR.Main.Engine;
using System.Collections.Generic;
using System.Linq;

namespace KR.Main.Entities
{
    public abstract class Query
    {
        public abstract bool Evaluate(World world, List<Edge> edges=null);

        /// <summary>
        /// Returns collection of edges from given state for a scenario step.
        /// </summary>
        protected IEnumerable<Edge> EdgesForStep(World world, State state, ScenarioStep step)
        {
            // TODO: handle EPSILON - 'any' actor
            return world.GetEdges(state).Where(egde => egde.Actor.Equals(step.Actor)).Where(edge => edge.Action.Equals(step.Action));
        }
    }
}
