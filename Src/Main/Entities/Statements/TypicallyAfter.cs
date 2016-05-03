using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KR.Main.Entities.Conditions;

namespace KR.Main.Entities.Statements
{
    public class TypicallyAfter
    {
        public ICondition Effect { get; private set; }
        public List<Tuple<Action, bool, List<Actor>>> Sequence { get; private set; }

        /// <summary>
        /// Creates instance of typically after sentence for given effect and sequence of actions.
        /// </summary>
        /// <param name="effect">effect for sentence</param>
        /// <param name="sequence">sequence of action with actors</param>
        public TypicallyAfter(ICondition effect, List<Tuple<Action, bool, List<Actor>>> sequence)
        {
            Effect = effect;
            Sequence = sequence;
        }

        public override string ToString()
        {
            string sequenceList = "";
            foreach (Tuple<Action, bool, List<Actor>> seq in Sequence)
            {
                string actorsList = "";
                foreach (Actor a in seq.Item3)
                {
                    if (actorsList == "")
                        actorsList = a.ToString();
                    else
                        actorsList = actorsList + ", " + a.ToString();
                }

                if (sequenceList == "")
                    sequenceList = "(" + seq.Item1.ToString().ToUpper() + (seq.Item2 ? ",~ " : ", ") + actorsList + ")";
                else
                    sequenceList = sequenceList + ", " + "(" + seq.Item1.ToString().ToUpper() + (seq.Item2 ? ",~ " : ", ") + actorsList + ")";
            }

            return Effect.ToString() + " typically after " + sequenceList;
        }
    }
}
