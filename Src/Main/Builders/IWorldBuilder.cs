using KR.Main.Entities;
using System.Collections.Generic;


namespace KR.Main.Builders
{
    interface IWorldBuilder
    {
        void SetFluents(List<Fluent> fluents);
        void SetActors(List<Actor> actors);
        void SetActions(List<Action> actions);
        void SetDomain(Domain domain);
    }
}
