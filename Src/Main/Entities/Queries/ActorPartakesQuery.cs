using KR.Main.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Main.Entities.Queries
{
    public abstract class ActorPartakesQuery : Query
    {
        protected Actor Actor { get; set; }

        protected Scenario Scenario { get; set; }

        public ActorPartakesQuery(Actor actor, Scenario scenario)
        {
            Actor = actor;
            Scenario = scenario;
        }

        public override bool Evaluate(World world, List<Edge> edges = null)
        {
            ScenarioEverExecutableQuery executable = new ScenarioEverExecutableQuery(Scenario);
            if(!executable.Evaluate(world))
            {
                // scenario is never executable - actor can not partake
                return false;
            }

            return DoEvaluate(world);
        }

        protected abstract bool DoEvaluate(World world);
    }
}
