using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KR.Main.Engine;
using KR.Main.Entities.Conditions;

namespace KR.Main.Entities.Queries
{
    public class AccessibleAlwaysScenarioQuery : Query
    {
        public AccessibleAlwaysScenarioQuery(ICondition pi, ICondition gamma, Scenario scenario)
        {

        }
        public override bool Evaluate(World world)
        {
            throw new NotImplementedException();
        }
    }
}
