using System;

namespace KR.Main.Entities
{
    class Fluent : ICondition
    {
        public bool Check(State state)
        {
            return state.GetValueOf(this);
        }
    }
}
