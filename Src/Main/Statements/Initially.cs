using KR.Main.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Main.Statements
{
    /// <summary>
    /// Sentence class that represents initially clause.
    /// </summary>
    class Initially
    {
        public ICondition Condition { get; private set; }

        /// <summary>
        /// Creates instance of initially sentence for given condition.
        /// </summary>
        /// <param name="condition">condition for sentence</param>
        public Initially(ICondition condition)
        {
            Condition = condition;
        }
    }
}
