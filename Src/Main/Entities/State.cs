using System;
using System.Collections.Generic;
using System.Linq;

namespace KR.Main.Entities
{
    public class State
    {
        public readonly Dictionary<Fluent, bool> Values = new Dictionary<Fluent, bool>();



        public bool this[Fluent fluent] => Values[fluent];

        public override string ToString()
        {
            return string.Join(" ,", Values.Where(v => v.Value).Select(v => v.Key.ToString()));
        }
    }
}
