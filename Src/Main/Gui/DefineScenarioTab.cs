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

namespace KR.Main.Gui
{
    public partial class DefineScenarioTab : UserControl
    {
        public DefineScenarioTab()
        {
            InitializeComponent();
        }
        
        public void setActionsAndActors(List<Entities.Action> actions, List<Actor> actors)
        {
            foreach (Entities.Action a in actions)
                actionComboBox.Items.Add(a);
            actionComboBox.SelectedIndex = 0;

            foreach (Actor a in actors)
                actorComboBox.Items.Add(a);
            actorComboBox.SelectedIndex = 0;
        }
    }
}
