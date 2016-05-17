using KR.Main.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Main.GraphLayout
{
    public static class GleeGraphFactory
    {
        public static Microsoft.Glee.Drawing.Graph Create(IEnumerable<Edge> edges)
        {
            var graph = new Microsoft.Glee.Drawing.Graph("graph");

            foreach (var edge in edges)
                graph.AddEdge(edge.From.ToString(), edge.ToEdgeLabel(), edge.To.ToString());

            return graph;
        }

        private static string ToEdgeLabel(this Edge edge)
        {
            return string.Format("({0} , {1})", edge.Action, edge.Actor);
        }

        //attributes
        //Microsoft.Glee.Drawing.Node n1 = graph.FindNode(strNode1);
        //n1.Attr.Fillcolor = Microsoft.Glee.Drawing.Color.SeaGreen;
        //n1.Attr.Shape = Microsoft.Glee.Drawing.Shape.DoubleCircle;

        //Microsoft.Glee.Drawing.Node n2 = graph.FindNode(strNode2);
        //n2.Attr.Fillcolor = Microsoft.Glee.Drawing.Color.Azure;
        //n2.Attr.Shape = Microsoft.Glee.Drawing.Shape.House;

        //Microsoft.Glee.Drawing.Node n3 = graph.FindNode(strNode3);
        //n3.Attr.Fillcolor = Microsoft.Glee.Drawing.Color.Brown;
        //n3.Attr.Shape = Microsoft.Glee.Drawing.Shape.Diamond  
    }
}
