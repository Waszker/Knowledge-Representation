using System;
using System.Collections.Generic;
using KR.Main.Entities;
using Action = KR.Main.Entities.Action;

namespace KR.Main
{
    sealed class World : IWorld
    {
        private static readonly Lazy<World> instance = new Lazy<World>(() => new World());
        public static World Instance => instance.Value;

        public IGraph Graph { get; private set; }

        private World()
        {

        }
       
        public List<State> GetAllStates(Condition condition)
        {
            throw new NotImplementedException();
        }
    }
}
