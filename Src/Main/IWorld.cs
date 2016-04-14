using System.Collections.Generic;
using KR.Main.Model;

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
