﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KR.Main.Engine;
using KR.Main.Entities.Conditions;

namespace KR.Main.Entities.Queries
{
    public class AccessibleTypicallyQuery : AccessibleTypicallyScenarioQuery
    {
        public AccessibleTypicallyQuery(ICondition pi, ICondition gamma, IEnumerable<State> startingStates = null) : base(pi, gamma, new Scenario())
        { }
    }
}
