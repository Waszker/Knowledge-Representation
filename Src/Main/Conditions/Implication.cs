using KR.Main.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Main.Conditions
{
    class Implication : ICondition
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
    }
}
