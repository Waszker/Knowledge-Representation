using System;
using System.Collections.Generic;
using KR.Main.Entities;
using KR.Main.Entities.Conditions;
using Action = KR.Main.Entities.Action;

namespace KR.Main
{
    sealed partial class World
    {
        public List<State> States { get; set; }
        public State InitialState { get; set; }
        public List<Fluent> Fluents { get; set; }
        public Domain Domain { get; set; }


        private Graph _graph;

        public World()
        {
            // TODO: Calculate ResN & ResAb sets.
            // TODO: Create _graph
        }

        public List<State> GetAllStates(ICondition condition)
        {
            throw new NotImplementedException();
        }

        public List<Edge> GetAllEdges(State fromState = null)
        {
            throw new NotImplementedException();
        }
    }
}
