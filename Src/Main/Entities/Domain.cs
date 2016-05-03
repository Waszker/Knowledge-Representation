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
    public class Domain
    {
        public readonly List<Initially> InitiallyClauses = new List<Initially>();
        public readonly List<Always> AlwaysClauses = new List<Always>();
        public readonly List<Causes> CausesClauses = new List<Causes>();
        public readonly List<Impossible> ImpossibleClauses = new List<Impossible>();
        public readonly List<Releases> ReleasesClauses = new List<Releases>();
        public readonly List<TypicallyCauses> TypicallyCausesClauses = new List<TypicallyCauses>();
        public readonly List<Preserves> PreservesClauses = new List<Preserves>();
        public readonly List<After> AfterClauses = new List<After>();
        public readonly List<Observable> ObservableClauses = new List<Observable>();
        public readonly List<TypicallyAfter> TypicallyAfterClauses = new List<TypicallyAfter>();


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
