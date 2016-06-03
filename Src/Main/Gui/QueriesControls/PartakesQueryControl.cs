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
using KR.Main.Entities.Queries;

namespace KR.Main.Gui.QueriesControls
{
    public partial class PartakesQueryControl : UserControl
    {
        private Scenario scenario;
        public PartakesQueryControl()
        {
            InitializeComponent();
        }

        public void setActors(List<Actor> _actors)
        {
            ActorComboBox.Items.Clear();
            foreach (Actor a in _actors)
                ActorComboBox.Items.Add(a);
            if (_actors.Count > 0)
                ActorComboBox.SelectedIndex = 0;
        }

        public void setScenario(Scenario _scenario)
        {
            this.ScenarioTextBox.Text = _scenario.ToString();
            scenario = _scenario;
        }

        public Query getQuery()
        {
            if (ActorComboBox.SelectedIndex >= 0 && scenario.Steps.Count > 0)
            {
                if (AlwaysRadioButton.Checked == true)
                {
                    return new ActorAlwaysPartakesQuery((Actor)ActorComboBox.SelectedItem, scenario);
                }
                else if (EverRadioButton.Checked == true)
                {
                    return new ActorEverPartakesQuery((Actor)ActorComboBox.SelectedItem, scenario);
                }
            }
            return null;
        }
    }
}
