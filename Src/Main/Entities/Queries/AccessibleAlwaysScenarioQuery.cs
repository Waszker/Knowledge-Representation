using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KR.Main.Engine;
using KR.Main.Entities.Conditions;

namespace KR.Main.Entities.Queries
{
    public class AccessibleAlwaysScenarioQuery : Query
    {
        private ICondition gamma;
        private ICondition pi;
        private Scenario scenario;

        public AccessibleAlwaysScenarioQuery(ICondition pi, ICondition gamma, Scenario scenario)
        {
            this.pi = pi;
            this.gamma = gamma;
            this.scenario = scenario;
        }
        public override bool Evaluate(World world, List<Edge> edges = null)
        {
            return world.GetStates(pi).All(s => AccessibleScenario(world, s));
        }

        private bool AccessibleScenario(World world, State startState)
        {
            var states = new List<State>() { startState };
            foreach (var step in scenario)
            {
                states = states.SelectMany(s => world.GetEdges(s)
                .Where(e => e.Action.Equals(step.Action) && e.Actor.Equals(step.Actor)).Select(e => e.To)).ToList();
                if (states.Count == 0) return false;
            }
            
            foreach (State s in states)
            {
                if (!DFSearch(world, new HashSet<State>(), s))
                    return false;
            }

            return true;
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
                foreach (var group in actionGroups)
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
                    if (!isAtLeastOneUnSuccessful) hasGammaBeenAchieved = true;
                }
            }

            close.Remove(state);
            return hasGammaBeenAchieved;
        }
    }


}
