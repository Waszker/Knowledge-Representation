namespace KR.Main.Entities
{
    /// <summary>
    /// Class representing fluent object.
    /// </summary>
    class Fluent
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
    }
}
