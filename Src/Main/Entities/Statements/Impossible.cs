using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KR.Main.Entities.Conditions;

namespace KR.Main.Entities.Statements
{
    class Impossible
    {
        public Action Action { get; private set; }
        public bool Exclusion { get; private set; }
        public List<Actor> Actors { get; private set; }
        public ICondition Condition { get; private set; }

        /// <summary>
        /// Creates instance of impossible sentence for given action, actors and condition.
        /// </summary>
        /// <param name="action">action for sentence</param>
        /// <param name="exclusion">exclusion of actors</param>
        /// <param name="actors">actors for sentence</param>
        /// <param name="condition">condition for sentence</param>
        public Impossible(Action action, bool exclusion, List<Actor> actors, ICondition condition)
        {
            Action = action;
            Exclusion = exclusion;
            Actors = actors;
            Condition = condition;
        }
    }
}
