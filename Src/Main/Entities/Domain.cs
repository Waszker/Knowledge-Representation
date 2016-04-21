using KR.Main.Statements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Main.Entities
{
    /// <summary>
    /// Class containing list of sentences.
    /// </summary>
    class Domain
    {
        private List<Initially> _initiallyClauses;

        /// <summary>
        /// 
        /// </summary>
        public Domain()
        {
            _initiallyClauses = new List<Initially>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sentence"></param>
        public void AddInitiallyClause(Initially sentence)
        {
            _initiallyClauses.Add(sentence);
        }
    }
}
