using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KR.Main.Entities.Statements;

namespace KR.Main.Entities
{
    /// <summary>
    /// Class containing list of sentences.
    /// </summary>
    class Domain
    {
        public List<Initially> InitiallyClauses = new List<Initially>();
        public List<Always> AlwaysClauses = new List<Always>();


        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="sentence"></param>
        //public void AddInitiallyClause(Initially sentence)
        //{
        //    _initiallyClauses.Add(sentence);
        //}
    }
}
