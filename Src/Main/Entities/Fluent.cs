using System;
using KR.Main.Entities.Conditions;

namespace KR.Main.Entities
{
    /// <summary>
    /// Class representing fluent object.
    /// </summary>
    class Fluent : ICondition
    {
        public string Name { get; private set; }

        /// <summary>
        /// Creates instance of an fluent object.
        /// </summary>
        /// <param name="name">fluent name</param>
        public Fluent(string name)
        {
            Name = name;
        }
        public bool Check(State state)
        {
            return state.GetValueOf(this);
        }
    }
}
