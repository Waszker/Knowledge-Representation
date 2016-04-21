using System;
using System.Collections.Generic;

namespace KR.Main.Entities
{
    class State
    {
        public Dictionary<Fluent, bool> Values = new Dictionary<Fluent, bool>();
        internal bool GetValueOf(Fluent fluent)
        {
            return Values[fluent];
        }
    }
}
