using KR.Main.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Main.Conditions
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
    }
}
