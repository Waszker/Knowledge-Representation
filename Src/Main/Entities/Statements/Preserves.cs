using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KR.Main.Entities.Conditions;

namespace KR.Main.Entities.Statements
{
    public class Preserves
    {
        public Action Action { get; private set; }
        public bool Exclusion { get; private set; }
        public List<Actor> Actors { get; private set; }
        public Fluent Fluent { get; private set; }
        public ICondition Condition { get; private set; }

        /// <summary>
        /// Creates instance of preserves sentence for given action, actors, fluent and condition.
        /// </summary>
        /// <param name="action">action for sentence</param>
        /// <param name="exclusion">exclusion of actors</param>
        /// <param name="actors">actors for sentence</param>
        /// <param name="fluent">fluent for sentence</param>
        /// <param name="condition">condition for sentence</param>
        public Preserves(Action action, bool exclusion, List<Actor> actors, Fluent fluent, ICondition condition)
        {
            Action = action;
            Exclusion = exclusion;
            Actors = actors;
            Fluent = fluent;
            Condition = condition;
        }
    }
}
