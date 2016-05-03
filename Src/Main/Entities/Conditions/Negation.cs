namespace KR.Main.Entities.Conditions
{
    class Negation : ICondition
    {
        private ICondition condition;
        public Negation(ICondition condition)
        {
            this.condition = condition;
        }
        public bool Check(State state)
        {
            return !condition.Check(state);
        }
        public override string ToString()
        {
            return "~" + condition.ToString();
        }
    }
}
