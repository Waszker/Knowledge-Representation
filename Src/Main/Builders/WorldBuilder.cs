using System;
using System.Collections.Generic;
using KR.Main.Entities;

namespace KR.Main.Builders
{
    class WorldBuilder : IWorldBuilder
    {
        private static readonly Lazy<WorldBuilder> instance = new Lazy<WorldBuilder>(() => new WorldBuilder());
        public static WorldBuilder Instance => instance.Value;

        private WorldBuilder() { }

        public World Build()
        {
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

        public void SetDomain(Domain domain)
        {
            throw new NotImplementedException();
        }
    }
}
