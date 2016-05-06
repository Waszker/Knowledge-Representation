using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Main.Entities.Conditions
{
    class True : ICondition
    {
        public bool Check(State state)
        {
            return true;
        }

        public override string ToString()
        {
            return "True";
        }
    }
}
