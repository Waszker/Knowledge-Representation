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

        public AccessibleAlwaysQuery(ICondition pi, ICondition gamma)
        {
            this.pi = pi;
            this.gamma = gamma;
        }

        public override bool Evaluate(World world, List<Edge> edges = null)
        {
            var states = world.GetStates(pi);
            bool returnValue = false;

            try
            {
                foreach(State s in states)
                {
                    if (DFSearch(world, new HashSet<State>(), s))
                        returnValue = true;
                }
            }
            catch(System.ArgumentException)
            {
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
                var actionGroups = world.GetEdges(state).GroupBy(edge => edge.Action);

                // Check states grouped by their actions
                foreach(var group in actionGroups)
                {
                    bool isAtLeastOneSuccessful = false;
                    bool isAtLeastOneUnSuccessful = false;

                    foreach (Edge e in group)
                    {
                        // Check if state can be visited
                        State s = e.To;
                        // If there's action that leads to already visited state we have a cycle - may cause always query to fail!
                        if (close.Contains(s)) { isAtLeastOneUnSuccessful = true; continue; }
                        // Recursively check if it leads to gamma-satisfying state
                        if (DFSearch(world, close, s)) isAtLeastOneSuccessful = true;
                        // If another state does not satisfy gamma (but previous did) throw an exception - always query will not be satisfied!
                        else if (isAtLeastOneSuccessful) throw new System.ArgumentException();
                    }

                    // If one of the paths took us to successful state, but there was other that did not -> always query is wrong
                    if (isAtLeastOneUnSuccessful && isAtLeastOneSuccessful) throw new System.ArgumentException();
                    // If there is at least one succesfull path, then we're good to go
                    if(isAtLeastOneSuccessful) hasGammaBeenAchieved = isAtLeastOneSuccessful;
                }
            }

            close.Remove(state);
            return hasGammaBeenAchieved;
        }
    }
}
