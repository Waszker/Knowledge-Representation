using KR.Main.Entities.Conditions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Main.Entities.Queries
{
    class AccessibleAlwaysQuery : Query
    {
        private ICondition gamma;
        private ICondition pi;

        public AccessibleAlwaysQuery(ICondition pi, ICondition gamma)
        {
            this.pi = pi;
            this.gamma = gamma;
        }
        public override bool Evaluate(World world)
        {
            var states = world.GetAllStates(pi);
            var open=new HashSet<State>(states.SelectMany(state=>world.GetAllEdges(state).Select(edge=>edge.To)));
            var close = new HashSet<State>();
            while (open.Count > 0)
            {
                var state = open.First();
                open.Remove(state);
                close.Add(state);
                foreach (var state2 in world.GetAllEdges(state).Select(edge=>edge.To))
                {
                    if (!close.Contains(state2)) open.Add(state2);
                }
            }
            return close.All(state=>gamma.Check(state));
        }
    }
}
