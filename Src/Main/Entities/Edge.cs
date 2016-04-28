namespace KR.Main.Entities
{
    public class Edge
    {
        public State From { get; set; }

        public State To { get; set; }

        public Actor Actor { get; set; }

        public Action Action { get; set; }

        public bool Abnormal { get; set; }
    }
}
