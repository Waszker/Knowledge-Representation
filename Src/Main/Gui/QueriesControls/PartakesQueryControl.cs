using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KR.Main.Entities;

namespace KR.Main.Gui.QueriesControls
{
    public partial class PartakesQueryControl : UserControl
    {
        public PartakesQueryControl()
        {
            InitializeComponent();
        }

        public void setActors(List<Actor> _actors)
        {
            foreach (Actor a in _actors)
                ActorComboBox.Items.Add(a);
            if (_actors.Count > 0)
                ActorComboBox.SelectedIndex = 0;
        }

        public void setScenario(Scenario scenario)
        {
            this.ScenarioTextBox.Text = scenario.ToString();
        }

        public Query getQuery()
        {
            return null;
        }
    }
}
