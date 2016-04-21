using KR.Main.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Main.Conditions
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
