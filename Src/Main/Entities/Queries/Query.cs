using KR.Main.Engine;
using System.Collections.Generic;
using System.Linq;

namespace KR.Main.Entities
{
    public abstract class Query
    {
        public abstract bool Evaluate(World world);

        /// <summary>
        /// Returns collection of edges from given state for a scenario step.
        /// </summary>
        protected IEnumerable<Edge> EdgesForStep(World world, State state, ScenarioStep step)
        {
            return world.GetEdges(state).Where(egde => egde.Actor.Equals(step.Actor)).Where(edge => edge.Action.Equals(step.Action));
        }
    }
}
