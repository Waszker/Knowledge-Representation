using System;
using System.Collections.Generic;
using System.Linq;
using KR.Main.Entities.Statements;

namespace KR.Main.Entities
{
    public class State
    {
        public readonly Dictionary<Fluent, bool> Values = new Dictionary<Fluent, bool>();



        public bool this[Fluent fluent] => Values[fluent];


        public State(List<Fluent> fluents, List<bool> values)
        {
            if (fluents.Count != values.Count)
                throw new ArgumentException();

            for (int i = 0; i < fluents.Count; i++)
                Values.Add(fluents[i], values[i]);
        }

        public override string ToString()
        {
            return string.Join(" ,", Values.Where(v => v.Value).Select(v => v.Key.ToString()));
        }







    }
}
