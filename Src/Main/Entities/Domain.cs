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
        public List<Causes> CausesClauses = new List<Causes>();
        public List<Impossible> ImpossibleClauses = new List<Impossible>();
        public List<Releases> ReleasesClauses = new List<Releases>();
        public List<TypicallyCauses> TypicallyCausesClauses = new List<TypicallyCauses>();
        public List<Preserves> PreservesClauses = new List<Preserves>();
        public List<After> AfterClauses = new List<After>();
        public List<Observable> ObservableClauses = new List<Observable>();
        public List<TypicallyAfter> TypicallyAfterClauses = new List<TypicallyAfter>();


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
