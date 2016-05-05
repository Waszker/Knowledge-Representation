using System;

namespace KR.Main.Entities
{
    /// <summary>
    /// Class representing actor object.
    /// </summary>
    public class Actor : IEquatable<Actor>
    {
        private readonly string _name;

        /// <summary>
        /// Creates instance of an actor object.
        /// </summary>
        /// <param name="name">actor name</param>
        public Actor(string name)
        {
            _name = name;
        }

        public bool Equals(Actor other)
        {
            return other._name.Equals(_name);
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
