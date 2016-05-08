using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Main.Entities.Queries
{
    public abstract class ActorPartakesQuery : Query
    {
        protected Actor actor;

        protected Scenario scenario;

        public ActorPartakesQuery(Actor actor, Scenario scenario)
        {
            this.actor = actor;
            this.scenario = scenario;
        }
    }
}
