using System;
using System.Collections.Generic;

namespace KR.Main.Entities
{
    public class State
    {
        public readonly Dictionary<Fluent, bool> Values = new Dictionary<Fluent, bool>();



        public bool this[Fluent fluent] => Values[fluent];
    }
}
