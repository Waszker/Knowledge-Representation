using KR.Main.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Glee.Drawing;
using Edge = KR.Main.Entities.Edge;

namespace KR.Main.GraphLayout
{
    public static class GleeGraphFactory
    {
        public static Microsoft.Glee.Drawing.Graph Create(IEnumerable<Edge> edges, IEnumerable<State> highlightedStates=null)
        {
            var graph = new Microsoft.Glee.Drawing.Graph("graph");
            graph.AddEdges(edges);
            if(highlightedStates != null)
                graph.AddHighlightedStates(highlightedStates);
            
            return graph;
        }

        private static void AddEdges(this Graph graph, IEnumerable<Edge> edges)
        {
            foreach (var edge in edges)
            {
                var gleeEdge = graph.AddEdge(edge.From.ToString(), edge.ToEdgeLabel(), edge.To.ToString());
                if (edge.Abnormal)
                {
                    gleeEdge.EdgeAttr.AddStyle(Microsoft.Glee.Drawing.Style.Dashed);
                }
            }
        }

        private static void AddHighlightedStates(this Graph graph, IEnumerable<State> highlightedStates)
        {
            foreach (var state in highlightedStates)
            {
                var node = graph.FindNode(state.ToString());
                if(node != null)
                    node.Attr.Shape = Shape.DoubleCircle;
            }
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
