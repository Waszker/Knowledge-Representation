namespace KR.Main.Entities.Conditions
{
    class Conjuction : ICondition
    {
        private ICondition left;
        private ICondition right;

        public Conjuction(ICondition right, ICondition left)
        {
            this.right = right;
            this.left = left;
        }
        public bool Check(State state)
        {
            return right.Check(state) && left.Check(state);
        }

        public override string ToString()
        {
            return left.ToString() + " ^ " + right.ToString();
        }
    }
}
