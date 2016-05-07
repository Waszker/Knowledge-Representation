using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Main.Entities
{
    /// <summary>
    /// Single step of scenario - action and antor 
    /// </summary>
    public class ScenarioStep
    {
        /// <summary>
        /// Action executed in this step.
        /// </summary>
        public Action Action { get; private set; }

        /// <summary>
        /// Actor executing action in this step
        /// </summary>
        public Actor Actor { get; private set; }

        /// <summary>
        /// Creates new scenario step
        /// </summary>
        /// <param name="_action">executed action</param>
        /// <param name="_actor">actor executing action</param>
        public ScenarioStep(Action _action, Actor _actor)
        {
            Action = _action;
            Actor = _actor;
        }

        public override string ToString()
        {
            return "(" + this.Action + ", " + this.Actor + ")";
        }
    }
}
