using KR.Main.Entities.Conditions;
using System.Collections.Generic;
using System.Linq;
using KR.Main.Engine;

namespace KR.Main.Entities.Queries
{
    public class AccessibleAlwaysQuery : Query
    {
        private ICondition gamma;
        private ICondition pi;
        private IEnumerable<State> _startingStates;

        public AccessibleAlwaysQuery(ICondition pi, ICondition gamma, IEnumerable<State> startingStates = null)
        {
            this.pi = pi;
            this.gamma = gamma;
            this._startingStates = startingStates;
        }

        public override bool Evaluate(World world, List<Edge> edges = null)
        {
            var states = _startingStates == null ? world.GetStates(pi) : _startingStates;
            bool returnValue = true;

            foreach (State s in states)
            {
                if (!DFSearch(world, new HashSet<State>(), s))
                    returnValue = false;
            }

            return returnValue;
        }

        private bool DFSearch(World world, HashSet<State> close, State state)
        {
            bool hasGammaBeenAchieved = gamma.Check(state);
            close.Add(state);

            // If there are some unvisited states and we haven't already found desired state
            if (!hasGammaBeenAchieved)
            {
                var actionGroups = world.GetEdges(state).GroupBy(edge => new { edge.Action, edge.Actor });

                // Check states grouped by their actions
                foreach(var group in actionGroups)
                {
                    bool isAtLeastOneUnSuccessful = false;

                    foreach (Edge e in group)
                    {
                        // Check if state can be visited
                        State s = e.To;
                        // If there's action that leads to already visited state we have a cycle - may cause always query to fail!
                        if (close.Contains(s)) { isAtLeastOneUnSuccessful = true; continue; }
                        // Recursively check if it leads to gamma-satisfying state
                        if (!DFSearch(world, close, s)) isAtLeastOneUnSuccessful = true;
                    }
                    // If all paths are leading to satisfying state we're good to go
                    if(!isAtLeastOneUnSuccessful) hasGammaBeenAchieved = true;
                }
            }

            close.Remove(state);
            return hasGammaBeenAchieved;
        }
    }
}
