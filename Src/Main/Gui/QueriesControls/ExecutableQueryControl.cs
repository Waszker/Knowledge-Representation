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

namespace KR.Main.Gui.ClauseControls
{
    public partial class ExecutableQueryControl : UserControl
    {
        public ExecutableQueryControl()
        {
            InitializeComponent();
        }

        public void setScenario(Scenario scenario)
        {
            this.ScenarioTextBox.Text = scenario.ToString();
        }
    }
}
