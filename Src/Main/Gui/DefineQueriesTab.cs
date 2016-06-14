using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KR.Main.Gui.ClauseControls;
using KR.Main.Entities;
using KR.Main.Gui.QueriesControls;
using KR.Main.Engine;

namespace KR.Main.Gui
{
    public partial class DefineQueriesTab : UserControl
    {
        UserControl[] queryControls;
        int currentQuery;
        public DefineQueriesTab()
        {
            InitializeComponent();

            currentQuery = 0;
            queryControls = new UserControl[5];
            queryControls[0] = new ExecutableQueryControl();
            queryControls[1] = new AccessibleWhenQueryControl();
            queryControls[2] = new AccessibleQueryControl();
            queryControls[3] = new PartakesQueryControl();
            queryControls[4] = new AfterScenarioQueryControl();

            queryControls[0].Anchor = AnchorStyles.Top;
            queryControls[1].Anchor = AnchorStyles.Top;
            queryControls[2].Anchor = AnchorStyles.Top;
            queryControls[3].Anchor = AnchorStyles.Top;
            queryControls[4].Anchor = AnchorStyles.Top;


            this.defineQueriesPanel.Controls.Add(queryControls[0], 0, 2);
            chooseQueryComboBox.SelectedIndex = 0;
        }

        public void ResetAll()
        {
            this.defineQueriesPanel.Controls.Remove(queryControls[currentQuery]);
            currentQuery = 0;
            queryControls = new UserControl[5];
            queryControls[0] = new ExecutableQueryControl();
            queryControls[1] = new AccessibleWhenQueryControl();
            queryControls[2] = new AccessibleQueryControl();
            queryControls[3] = new PartakesQueryControl();
            queryControls[4] = new AfterScenarioQueryControl();

            queryControls[0].Anchor = AnchorStyles.Top;
            queryControls[1].Anchor = AnchorStyles.Top;
            queryControls[2].Anchor = AnchorStyles.Top;
            queryControls[3].Anchor = AnchorStyles.Top;
            queryControls[4].Anchor = AnchorStyles.Top;


            this.defineQueriesPanel.Controls.Add(queryControls[0], 0, 2);
            chooseQueryComboBox.SelectedIndex = 0;
        }

        public void setFluentsAndActors(List<Fluent> fluents, List<Actor> actors)
        {
            ((PartakesQueryControl)queryControls[3]).setActors(actors);
            ((AccessibleWhenQueryControl)queryControls[1]).setFluents(fluents);
            ((AccessibleQueryControl)queryControls[2]).setFluents(fluents);
            ((AfterScenarioQueryControl)queryControls[4]).setFluents(fluents);
        }

        public void setScenario(Scenario scenario)
        {
            ((ExecutableQueryControl)queryControls[0]).setScenario(scenario);
            ((AccessibleWhenQueryControl)queryControls[1]).setScenario(scenario);
            ((PartakesQueryControl)queryControls[3]).setScenario(scenario);
            ((AfterScenarioQueryControl)queryControls[4]).setScenario(scenario);
        }

        private void chooseQueryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.defineQueriesPanel.Controls.Remove(queryControls[currentQuery]);
            currentQuery = chooseQueryComboBox.SelectedIndex;
            this.defineQueriesPanel.Controls.Add(queryControls[currentQuery], 0, 2);
            this.answer.Text = "?";
        }

        private void checkQueryButton_Click(object sender, EventArgs e)
        {
            bool result = false;
            switch (currentQuery)
            {
                case 0: //executable
                    {
                        Query query = ((ExecutableQueryControl)queryControls[currentQuery]).getQuery();
                        if (query != null)
                        {
                            result = query.Evaluate(World.Instance);
                            this.answer.Text = result.ToString();
                        }
                        break;
                    }
                case 1: //accesible when
                    {
                        Query query = ((AccessibleWhenQueryControl)queryControls[currentQuery]).getQuery();
                        if (query != null)
                        {
                            result = query.Evaluate(World.Instance);
                            this.answer.Text = result.ToString();
                        }
                        break;
                    }
                case 2: //accessible
                    {
                        Query query = ((AccessibleQueryControl)queryControls[currentQuery]).getQuery();
                        if (query != null)
                        {
                            result = query.Evaluate(World.Instance);
                            this.answer.Text = result.ToString();
                        }
                        break;
                    }
                case 3: //partakes
                    {
                        Query query = ((PartakesQueryControl)queryControls[currentQuery]).getQuery();
                        if (query != null)
                        {
                            result = query.Evaluate(World.Instance);
                            this.answer.Text = result.ToString();
                        }
                        break;
                    }
                case 4: //after
                    {
                        Query query = ((AfterScenarioQueryControl)queryControls[currentQuery]).getQuery();
                        if (query != null)
                        {
                            result = query.Evaluate(World.Instance);
                            this.answer.Text = result.ToString();
                        }
                        break;
                    }
            }
        }

        private void showGraphButton_Click(object sender, EventArgs e)
        {
            var graphLayout = new GraphLayout.GraphLayout(World.Instance.GetEdges());
            graphLayout.Show();
        }
    }
}
