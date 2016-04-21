using KR.Main.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Main.Conditions
{
    class Equivalence : ICondition
    {
        private ICondition left;
        private ICondition right;

        public Equivalence(ICondition right, ICondition left)
        {
            this.right = right;
            this.left = left;
        }
        public bool Check(State state)
        {
            return !(right.Check(state) ^ left.Check(state));
        }
    }
}
