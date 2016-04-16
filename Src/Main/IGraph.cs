using System.Collections.Generic;
using KR.Main.Entities;

namespace KR.Main
{
    interface IGraph
    {
        List<Edge> GetAllEdges(State fromState = null);
    }
}
