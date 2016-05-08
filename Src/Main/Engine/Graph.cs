using System;
using System.Collections.Generic;
using System.Linq;
using KR.Main.Entities;
using KR.Main.Entities.Statements;
using Action = KR.Main.Entities.Action;

namespace KR.Main.Engine
{
    sealed partial class World
    {
        private class Graph
        {
            private List<Edge> _edges = new List<Edge>();

            public Graph(List<Action> actions, List<Actor> actors, List<State> states)
            {
                foreach (var state in states)
                {
                    foreach (var action in actions)
                    {
                        foreach (var actor in actors)
                        {
                            var resAb = Instance.GetStates(action, actor, state, true);
                            var resN = Instance.GetStates(action, actor, state, false);
                            foreach (var resAbState in resAb)
                            {
                                _edges.Add(new Edge()
                                {
                                    Actor = actor,
                                    Abnormal = true,
                                    Action = action,
                                    From = state,
                                    To = resAbState,
                                });
                            }
                            foreach (var resNState in resN)
                            {
                                _edges.Add(new Edge()
                                {
                                    Actor = actor,
                                    Abnormal = false,
                                    Action = action,
                                    From = state,
                                    To = resNState,
                                });
                            }
                        }
                    }
                }
            }


            public List<Edge> GetEdges(State from = null)
            {
                if (from == null)
                    return _edges;
                return _edges.Where(t => t.From == from).ToList();
            }

            public HashSet<State> GetInitialStates(HashSet<State> candidates, List<After> afterClauses, List<TypicallyAfter> tAfterClauses, 
                List<ObservableAfter> oAfterClauses)
            {
                HashSet<State> initialStates = new HashSet<State>(candidates);

                /*
                 *  TODO
                 *  Przefiltrować zbiór initialStates tak, żeby zostały zwrócone tylko stany początkowe spełniające wszystkie ograniczenia 
                 *  narzucone przez zdania 'After', 'Typically After', 'Observable After'.
                 * 
                 *  Jeżeli wyjdzie ich więcej niż jeden albo równe zero, to zwracać odpowiednio wszystkie albo pustą listę - wtedy klasa
                 *  World wywołująca tę metodę rzuci odpowiedni wyjątek.
                 *  
                 */

                return initialStates;
            }
        }
    }
}
