using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KR.Main.Entities.Statements;

namespace KR.Main.Entities
{
    /// <summary>
    /// Class of objects that make up sequences in <see cref="After"/>, <see cref="TypicallyAfter"/>, 
    /// <see cref="ObservableAfter"/> clauses.
    /// </summary>
    public class AfterTriple
    {
        public Action Action { get; private set; }
        public bool Exclusion { get; private set; }
        public List<Actor> Actors { get; private set; }

        public AfterTriple(Action action, bool exclusion, List<Actor> actors)
        {
            Action = action;
            Exclusion = exclusion;
            Actors = actors;
        }
    }
}
