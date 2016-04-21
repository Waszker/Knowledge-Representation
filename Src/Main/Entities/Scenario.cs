using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Main.Entities
{
    /// <summary>
    /// Represents scenario - actions and actors in given order.
    /// </summary>
    class Scenario
    {
        /// <summary>
        /// Ordered list of scenario steps.
        /// </summary>
        public IList<ScenarioStep> Steps { get; set; }
    }
}
