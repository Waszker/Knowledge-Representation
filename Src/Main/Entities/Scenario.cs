using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Main.Entities
{
    /// <summary>
    /// Represents scenario - actions and actors in given order.
    /// </summary>
    public class Scenario : IEnumerable<ScenarioStep>
    {
        /// <summary>
        /// Ordered list of scenario steps.
        /// </summary>
        public readonly List<ScenarioStep> Steps = new List<ScenarioStep>();

        /// <summary>
        /// Adds new step to scenario
        /// </summary>
        /// <param name="step">added step</param>
        public void AddScenarioStep(ScenarioStep step)
        {
            Steps.Add(step);
        }

        public IEnumerator<ScenarioStep> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string s = "";
            foreach (ScenarioStep ss in Steps)
            {
                if (s == "")
                    s = ss.ToString();
                else
                    s = s + ", " + ss.ToString();
            }
            return s;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Steps.GetEnumerator();
        }
    }
}
