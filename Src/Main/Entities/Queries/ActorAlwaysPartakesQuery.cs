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
        public ActorAlwaysPartakesQuery(Actor actor, Scenario scenario) : base(actor, scenario)
        {

        }

        public override bool Evaluate(World world)
        {
            // TODO: implement
            throw new NotImplementedException();
        }
    }
}
