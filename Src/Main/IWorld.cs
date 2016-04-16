using System.Collections.Generic;
using KR.Main.Entities;

namespace KR.Main
{
    interface IWorld
    {
        IGraph Graph { get; }

        void SetFluents(List<Fluent> fluents);
        void SetActors(List<Actor> actors);
        void SetActions(List<Action> actions);
        /* void SetZdania( ?? ); - do ustalenia: reprezentacja zdan dziedziny */

        void Build();

        List<State> GetAllStates(Condition condition);
    }
}
