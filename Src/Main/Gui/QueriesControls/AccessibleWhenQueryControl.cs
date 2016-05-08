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
    public partial class AccessibleWhenQueryControl : UserControl
    {
        public AccessibleWhenQueryControl()
        {
            InitializeComponent();
        }

        public void setScenario(Scenario scenario)
        {
            this.ScenarioTextBox.Text = scenario.ToString();
        }

        public void setFluents(List<Fluent> _fluents)
        {
            this.accessibleFormulaControl.setFluents(_fluents);
            this.ifFormulaControl.setFluents(_fluents);
        }

        public Query getQuery()
        {
            return null;
        }

        private void ifCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ifCheckBox.Checked == true)
                ifFormulaControl.Enabled = true;
            else
                ifFormulaControl.Enabled = false;
        }
    }
}
