using KR.Main.Entities;
using System.Collections.Generic;


namespace KR.Main.Builders
{
    interface IWorldBuilder : IBuilder<IWorld>
    {
        void SetFluents(List<Fluent> fluents);
        void SetActors(List<Actor> actors);
        void SetActions(List<Action> actions);
        /* void SetZdania( ?? ); - do ustalenia: reprezentacja zdan dziedziny */
    }
}
