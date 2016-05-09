using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KR.Main.Entities.Conditions;

namespace KR.Main.Entities.Statements
{
    public class After
    {
        public ICondition Effect { get; private set; }
        public List<AfterTriple> Sequence { get; private set; }

        /// <summary>
        /// Creates instance of after sentence for given effect and sequence of actions.
        /// </summary>
        /// <param name="effect">effect for sentence</param>
        /// <param name="sequence">sequence of action with actors</param>
        public After(ICondition effect, List<AfterTriple> sequence)
        {
            Effect = effect;
            Sequence = sequence;
        }

        public override string ToString()
        {
            string sequenceList = "";
            foreach (AfterTriple seq in Sequence)
            {
                string actorsList = "";
                foreach (Actor a in seq.Actors)
                {
                    if (actorsList == "")
                        actorsList = a.ToString();
                    else
                        actorsList = actorsList + ", " + a.ToString();
                }

                if (sequenceList == "")
                    sequenceList = "(" + seq.Action.ToString().ToUpper() + (seq.Exclusion ? ",~ " : ", ") + actorsList + ")";
                else
                    sequenceList = sequenceList + ", " + "(" + seq.Action.ToString().ToUpper() + (seq.Exclusion ? ",~ " : ", ") + actorsList + ")";
            }

            return Effect.ToString() + " after " + sequenceList;
        }
    }
}
