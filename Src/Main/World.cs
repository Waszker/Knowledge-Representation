using System;
using System.Collections.Generic;
using KR.Main.Model;
using Action = KR.Main.Model.Action;

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

        #region Builder methods

        public void SetFluents(List<Fluent> fluents)
        {
            throw new NotImplementedException();
        }

        public void SetActors(List<Actor> actors)
        {
            throw new NotImplementedException();
        }

        public void SetActions(List<Action> actions)
        {
            throw new NotImplementedException();
        }

        public void Build()
        {
            // ...
            // Graph = ...;

            throw new NotImplementedException();
        }

        #endregion

        public List<State> GetAllStates(Condition condition)
        {
            throw new NotImplementedException();
        }
    }
}
