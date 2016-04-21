using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Main.Entities
{
    /// <summary>
    /// Single step of scenario - action and set of actors (usually one specific actor or 'epsilon' - all actors).
    /// </summary>
    abstract class ScenarioStep
    {
        /// <summary>
        /// Action executed in this step.
        /// </summary>
        public Action Action
        {
            get; set;
        }

        /// <summary>
        /// Actor(s) executing the action in this step.
        /// </summary>
        /// <returns>Set of actors which execute the action</returns>
        public abstract ICollection<Actor> GetActors();
    }
}
