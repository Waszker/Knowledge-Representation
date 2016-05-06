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
            if (condition == null) condition = new True();
            Action = action;
            Exclusion = exclusion;
            Actors = actors;
            Fluent = fluent;
            Condition = condition;
        }

        public override string ToString()
        {
            string actorsList = "";
            foreach (Actor a in Actors)
            {
                if (actorsList == "")
                    actorsList = a.ToString();
                else
                    actorsList = actorsList + ", " + a.ToString();
            }
            if (Condition == null)
                return "(" + Action.ToString().ToUpper() + (Exclusion ? ",~ " : ", ") + actorsList + ") preserves " + Fluent.ToString();
            else
                return "(" + Action.ToString().ToUpper() + (Exclusion ? ",~ " : ", ") + actorsList + ") preserves " + Fluent.ToString() + " if " + Condition.ToString();
        }
    }
}
