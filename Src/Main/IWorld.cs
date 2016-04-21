using System.Collections.Generic;
using KR.Main.Entities;

namespace KR.Main
{
    interface IWorld
    {
        IGraph Graph { get; }      
        List<State> GetAllStates(Condition condition);
    }
}
