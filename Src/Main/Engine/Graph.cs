using System.Collections.Generic;
using System.Linq;
using KR.Main.Entities;
using Action = KR.Main.Entities.Action;

namespace KR.Main.Engine
{
    sealed partial class World
    {
        /// <summary>
        /// Do budowy grafu potrzebuje przekazanych zbiorów ResAb i ResN. Proponuję na przykład taki interfejs, może być coś innego to tylko taki pomysł
        /// </summary>
        public interface IRes
        {
            /// <summary>
            /// Returns collection of states - ResAb or ResN
            /// </summary>
            /// <param name="abnormal">ResAb or ResN</param>
            /// <param name="action"></param>
            /// <param name="actor"></param>
            /// <param name="state"></param>
            /// <returns>Collection of states</returns>
            ICollection<State> GetStates(bool abnormal, Action action, Actor actor, State state);
        }

        private class Graph
        {
            private List<Edge> _edges = new List<Edge>(); 

            public Graph(IRes res, ICollection<Action> actions, ICollection<Actor> actors, ICollection<State> states)
            {
                foreach (var state in states)
                {
                    foreach (var action in actions)
                    {
                        foreach (var actor in actors)
                        {
                            var resAb = res.GetStates(true, action, actor, state);
                            var resN = res.GetStates(false, action, actor, state);
                            foreach (var resAbState in resAb)
                            {
                                _edges.Add(new Edge()
                                {
                                    Actor = actor,
                                    Abnormal = true,
                                    From = state,
                                    To = resAbState,
                                });
                            }
                            foreach (var resNState in resAb)
                            {
                                _edges.Add(new Edge()
                                {
                                    Actor = actor,
                                    Abnormal = false,
                                    From = state,
                                    To = resNState,
                                });
                            }
                        }
                    }
                }
            }


            public List<Edge> GetAllEdges(State fromState = null)
            {
                if (fromState == null) return _edges;
                return _edges.Where(t => t.From == fromState).ToList();
            }
        }
    }
}
