using System;
using System.Collections.Generic;
using System.Linq;
using KR.Main.Entities.Statements;

namespace KR.Main.Entities
{
    public class State : IEquatable<State>
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
            return string.Join(" ,", Values.Select(v => (v.Value ? string.Empty : "-") + v.Key.ToString()));
        }

        public bool Equals(State other)
        {
            if (Values.Count != other.Values.Count)
                return false;

            var keys = Values.Keys;
            foreach (var key in keys)
            {
                if (Values[key] != other.Values[key])
                    return false;
            }
            return true;
        }
    }
}
