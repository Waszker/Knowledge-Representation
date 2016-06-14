using KR.Main.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR.Main.GraphLayout
{
    public class GraphLayout
    {
        public void Show(IEnumerable<Edge> edges, IEnumerable<State> highlightedStates = null)
        {
            if (edges == null)
                throw new ArgumentNullException("edges");

            var graph = GleeGraphFactory.Create(edges, highlightedStates);
            ShowGraphDialog(graph);          
        }

        private void ShowGraphDialog(Microsoft.Glee.Drawing.Graph graph)
        {
            //create a form
            System.Windows.Forms.Form form = new System.Windows.Forms.Form();

            //create a viewer object
            Microsoft.Glee.GraphViewerGdi.GViewer viewer = new Microsoft.Glee.GraphViewerGdi.GViewer();

            //bind the graph to the viewer
            viewer.Graph = graph;

            //associate the viewer with the form
            form.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            form.Controls.Add(viewer);
            form.ResumeLayout();

            //show the form
            form.ShowDialog();
        }
    }
}
