using System;
using System.Collections.Generic;
using KR.Main.Entities;
using Action = KR.Main.Entities.Action;

namespace KR.Main
{
    sealed class World
    {
        public IGraph Graph { get; private set; }

        public List<State> GetAllStates(ICondition condition)
        {
            throw new NotImplementedException();
        }
    }
}
