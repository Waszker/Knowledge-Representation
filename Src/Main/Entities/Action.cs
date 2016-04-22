using System;

namespace KR.Main.Entities
{
    /// <summary>
    /// Class representing action object.
    /// </summary>
    public class Action : IEquatable<Action>
    {
        public string _name;

        /// <summary>
        /// Creates instance of an action object.
        /// </summary>
        /// <param name="name">action name</param>
        public Action(string name)
        {
            _name = name;
        }

        public bool Equals(Action other)
        {
            return other._name.Equals(_name);
        }

        public override string ToString()
        {
            return this._name;
        }
    }
}
