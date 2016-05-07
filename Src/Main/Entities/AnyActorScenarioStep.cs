using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Main.Entities
{
    /// <summary>
    /// Scenario step - action executed by any actor.
    /// </summary>
    class AnyActorScenarioStep : ScenarioStep
    {
        public override ICollection<Actor> GetActors()
        {
            // TODO: return collection of all actors.
            throw new NotImplementedException();
        }
    }
}
