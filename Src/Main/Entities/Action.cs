namespace KR.Main.Entities
{
    /// <summary>
    /// Class representing action object.
    /// </summary>
    class Action
    {
        public string Name { get; private set; }

        /// <summary>
        /// Creates instance of an action object.
        /// </summary>
        /// <param name="name">action name</param>
        public Action(string name)
        {
            Name = name;
        }
    }
}
