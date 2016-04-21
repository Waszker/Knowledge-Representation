namespace KR.Main.Entities
{
    /// <summary>
    /// Class representing actor object.
    /// </summary>
    class Actor
    {
        public string Name { get; private set; }

        /// <summary>
        /// Creates instance of an actor object.
        /// </summary>
        /// <param name="name">actor name</param>
        public Actor(string name)
        {
            Name = name;
        }
    }
}
