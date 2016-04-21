namespace KR.Main.Entities.Conditions
{
    class Alternative : ICondition
    {
        private ICondition left;
        private ICondition right;

        public Alternative(ICondition right, ICondition left)
        {
            this.right = right;
            this.left = left;
        }
        public bool Check(State state)
        {
            return right.Check(state) || left.Check(state);
        }
    }
}
