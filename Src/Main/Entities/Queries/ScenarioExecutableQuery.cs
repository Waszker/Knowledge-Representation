using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Main.Entities.Queries
{
    abstract class ScenarioExecutableQuery : Query
    {
        protected Scenario scenario;

        public ScenarioExecutableQuery(Scenario scenario)
        {
            this.scenario = scenario;
        }
    }
}
