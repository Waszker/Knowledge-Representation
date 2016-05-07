using KR.Main.Entities.Conditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Main.Entities.Statements
{
    public class Causes
    {
        public Action Action { get; private set; }
        public bool Exclusion { get; private set; }
        public List<Actor> Actors { get; private set; }
        public ICondition Effect { get; private set; }
        public ICondition Condition { get; private set; }

        /// <summary>
        /// Creates instance of causes sentence for given action, actors, effect and condition.
        /// </summary>
        /// <param name="action">action for sentence</param>
        /// <param name="exclusion">exclusion of actors</param>
        /// <param name="actors">actors for sentence</param>
        /// <param name="effect">effect for sentence</param>
        /// <param name="condition">condition for sentence</param>
        public Causes(Action action, bool exclusion, List<Actor> actors, ICondition effect, ICondition condition)
        {
            if (condition == null) condition = new True();
            Action = action;
            Exclusion = exclusion;
            Actors = actors??new List<Actor>();
            Effect = effect;
            Condition = condition;
        }

        public override string ToString()
        {
            string actorsList = "";
            foreach(Actor a in Actors)
            {
                if (actorsList == "")
                    actorsList = a.ToString();
                else
                    actorsList = actorsList + ", " + a.ToString();
            }
            if(Condition==null)
                return "(" + Action.ToString().ToUpper() + (Exclusion ? ",~ " : ", ") + actorsList + ") causes " + Effect.ToString();
            else
                return "(" + Action.ToString().ToUpper() + (Exclusion ? ",~ " : ", ") + actorsList + ") causes " + Effect.ToString() + " if " + Condition.ToString();
        }
    }
}
