using KR.Main.Entities.Conditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Main.Entities.Statements
{
    public class Always
    {
        public ICondition Condition { get; private set; }

        /// <summary>
        /// Creates instance of alwaays sentence for given condition.
        /// </summary>
        /// <param name="condition">condition for sentence</param>
        public Always(ICondition condition)
        {
            Condition = condition;
        }
    }
}
