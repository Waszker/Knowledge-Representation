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


        public void AddInitiallyClause(Initially clause)
        {
            InitiallyClauses.Add(clause);
        }
        public void DeleteInitiallyClause(Initially clause)
        {
            InitiallyClauses.Remove(clause);
        }

        public void AddAlwaysClause(Always clause)
        {
            AlwaysClauses.Add(clause);
        }
        public void DeleteAlwaysClause(Always clause)
        {
            AlwaysClauses.Remove(clause);
        }

        public void AddCausesClause(Causes clause)
        {
            CausesClauses.Add(clause);
        }
        public void DeleteCausesClause(Causes clause)
        {
            CausesClauses.Remove(clause);
        }

        public void AddImpossibleClause(Impossible clause)
        {
            ImpossibleClauses.Add(clause);
        }
        public void DeleteImpossibleClause(Impossible clause)
        {
            ImpossibleClauses.Remove(clause);
        }

        public void AddReleasesClause(Releases clause)
        {
            ReleasesClauses.Add(clause);
        }
        public void DeleteReleasesClause(Releases clause)
        {
            ReleasesClauses.Remove(clause);
        }

        public void AddTypicallyCausesClause(TypicallyCauses clause)
        {
            TypicallyCausesClauses.Add(clause);
        }
        public void DeleteTypicallyCausesClause(TypicallyCauses clause)
        {
            TypicallyCausesClauses.Remove(clause);
        }

        public void AddPreservesClause(Preserves clause)
        {
            PreservesClauses.Add(clause);
        }
        public void DeletePreservesClause(Preserves clause)
        {
            PreservesClauses.Remove(clause);
        }

        public void AddAfterClause(After clause)
        {
            AfterClauses.Add(clause);
        }
        public void DeleteAfterClause(After clause)
        {
            AfterClauses.Remove(clause);
        }

        public void AddObservableClause(Observable clause)
        {
            ObservableClauses.Add(clause);
        }
        public void DeleteObservableClause(Observable clause)
        {
            ObservableClauses.Remove(clause);
        }

        public void AddTypicallyAfterClause(TypicallyAfter clause)
        {
            TypicallyAfterClauses.Add(clause);
        }
        public void DeleteTypicallyAfterClause(TypicallyAfter clause)
        {
            TypicallyAfterClauses.Remove(clause);
        }
    }
}
