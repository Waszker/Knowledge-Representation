using KR.Main.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Main.Entities.Queries
{
    class ScenarioAlwaysExecutableQuery : ScenarioExecutableQuery
    {
        public ScenarioAlwaysExecutableQuery(Scenario scenario) : base(scenario)
        {

        }

        public override bool Evaluate(World world)
        {
            // TODO: implement this
            throw new NotImplementedException();
        }
    }
}
