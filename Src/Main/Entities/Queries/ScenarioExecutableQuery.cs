using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Main.Entities.Queries
{
    public abstract class ScenarioExecutableQuery : Query
    {
        protected Scenario Scenario { get; set; }

        public ScenarioExecutableQuery(Scenario scenario)
        {
            this.Scenario = scenario;
        }
    }
}
