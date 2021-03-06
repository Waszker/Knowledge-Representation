﻿namespace KR.Main.Entities.Conditions
{
    public class Implication : ICondition
    {
        private ICondition from;
        private ICondition to;

        public Implication(ICondition from, ICondition to)
        {
            this.from = from;
            this.to = to;
        }
        public bool Check(State state)
        {
            return !from.Check(state) || to.Check(state);
        }

        public override string ToString()
        {
            return from.ToString() + " -> " + to.ToString();
        }
    }
}
