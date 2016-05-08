using KR.Main.Engine;
using KR.Main.Entities.Conditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Main.Entities.Queries
{
    public class AccessibleEverScenarioQuery :Query
    {
        public AccessibleEverScenarioQuery(ICondition pi, ICondition gamma, Scenario scenario)
        {

        }
        public override bool Evaluate(World world)
        {
            throw new NotImplementedException();
        }
    }
}
