using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KR.Main.Entities;

namespace KR.Main.Builders.Implementations
{
    class WorldBuilder : IWorldBuilder
    {
        public IWorld GetResult()
        {
            // ...
            // Graph = ...;

            throw new NotImplementedException();
        }

        public void SetActions(List<Entities.Action> actions)
        {
            throw new NotImplementedException();
        }

        public void SetActors(List<Actor> actors)
        {
            throw new NotImplementedException();
        }

        public void SetFluents(List<Fluent> fluents)
        {
            throw new NotImplementedException();
        }
    }
}
