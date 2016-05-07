namespace KR.Main.Entities.Conditions
{
    public class Negation : ICondition
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
            if(condition is Fluent)
                return " ¬ " + condition.ToString();
            return " ¬ (" + condition.ToString()+")";
        }
    }
}
