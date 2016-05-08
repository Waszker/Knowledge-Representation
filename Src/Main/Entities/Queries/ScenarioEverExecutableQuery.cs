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
        public ScenarioEverExecutableQuery(Scenario scenario) : base(scenario)
        {

        }

        public override bool Evaluate(World world)
        {
            // TODO: implement
            throw new NotImplementedException();
        }
    }
}
