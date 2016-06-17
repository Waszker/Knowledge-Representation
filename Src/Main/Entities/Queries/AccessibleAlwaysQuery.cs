using KR.Main.Entities.Conditions;

namespace KR.Main.Entities.Queries
{
    public class AccessibleAlwaysQuery : AccessibleAlwaysScenarioQuery
    {
        public AccessibleAlwaysQuery(ICondition pi, ICondition gamma)
            : base(pi, gamma, new Scenario())
        { }
    }
}
