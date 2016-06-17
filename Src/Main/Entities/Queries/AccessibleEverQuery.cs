using KR.Main.Engine;
using KR.Main.Entities.Conditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Main.Entities.Queries
{
    public class AccessibleEverQuery : AccessibleEverScenarioQuery
    {
        public AccessibleEverQuery(ICondition pi, ICondition gamma) 
            : base(pi, gamma, new Scenario())
        { }

    }
}
