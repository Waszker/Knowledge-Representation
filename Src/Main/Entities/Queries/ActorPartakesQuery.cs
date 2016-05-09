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
    }
}
