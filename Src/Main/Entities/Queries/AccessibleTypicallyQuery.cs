using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KR.Main.Engine;
using KR.Main.Entities.Conditions;

namespace KR.Main.Entities.Queries
{
    public class AccessibleTypicallyQuery : Query
    {
        private ICondition gamma;
        private ICondition pi;

        public AccessibleTypicallyQuery(ICondition pi, ICondition gamma)
        {
            this.pi = pi;
            this.gamma = gamma;
        }
        public override bool Evaluate(World world)
        {
            var states = world.GetStates(pi);
            return states.All(s => Accessible(world, s));
        }

        private bool Accessible(World world, State state)
        {
            var open = new HashSet<State>(world.GetEdges(state).Where(edge=>!edge.Abnormal).Select(edge => edge.To));
            var close = new HashSet<State>();
            while (open.Count > 0)
            {
                var state2 = open.First();
                if (gamma.Check(state2)) return true;
                open.Remove(state2);
                close.Add(state2);
                foreach (var state3 in world.GetEdges(state2).Where(edge => !edge.Abnormal).Select(edge => edge.To).Distinct())
                {
                    if (!close.Contains(state3)) open.Add(state3);
                }
            }
            return false;
        }
    }
}
