using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Main.Entities
{
    /// <summary>
    /// Step of scenario - action executed by one specific actor.
    /// </summary>
    class SingleActorScenatioStep : ScenarioStep
    {
        /// <summary>
        /// Actor, which executes the action.
        /// </summary>
        public Actor Actor { private get; set; }

        public override ICollection<Actor> GetActors()
        {
            return new List<Actor> { Actor };
        }
    }
}
