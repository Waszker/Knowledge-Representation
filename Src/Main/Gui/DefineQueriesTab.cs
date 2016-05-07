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
            queryControls = new UserControl[4];
            queryControls[0] = new ExecutableQueryControl();
            queryControls[1] = new ExecutableQueryControl();
            queryControls[2] = new ExecutableQueryControl();
            queryControls[3] = new PartakesQueryControl();

            queryControls[0].Anchor = AnchorStyles.Top;
            queryControls[1].Anchor = AnchorStyles.Top;
            queryControls[2].Anchor = AnchorStyles.Top;
            queryControls[3].Anchor = AnchorStyles.Top;

            this.defineQueriesPanel.Controls.Add(queryControls[0], 0, 2);
            chooseQueryComboBox.SelectedIndex = 0;
        }

        public void setFluentsAndActors(List<Fluent> fluents, List<Actor> actors)
        {
            ((PartakesQueryControl)queryControls[3]).setActors(actors);
        }

        public void setScenario(Scenario scenario)
        {
            ((ExecutableQueryControl)queryControls[0]).setScenario(scenario);

            ((PartakesQueryControl)queryControls[3]).setScenario(scenario);

        }

        private void chooseQueryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.defineQueriesPanel.Controls.Remove(queryControls[currentQuery]);
            currentQuery = chooseQueryComboBox.SelectedIndex;
            this.defineQueriesPanel.Controls.Add(queryControls[currentQuery], 0, 2);
        }
    }
}
