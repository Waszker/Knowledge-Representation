using System.Collections.Generic;
using KR.Main.Model;

namespace KR.Main
{
    interface IGraph
    {
        List<Edge> GetAllEdges(State fromState = null);
    }
}
