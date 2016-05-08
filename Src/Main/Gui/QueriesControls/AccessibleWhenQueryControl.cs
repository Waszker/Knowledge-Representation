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
    public partial class AccessibleWhenQueryControl : UserControl
    {
        private Scenario scenario;
        public AccessibleWhenQueryControl()
        {
            InitializeComponent();
        }

        public void setScenario(Scenario _scenario)
        {
            this.ScenarioTextBox.Text = _scenario.ToString();
            scenario = _scenario;
        }

        public void setFluents(List<Fluent> _fluents)
        {
            this.accessibleFormulaControl.setFluents(_fluents);
            this.ifFormulaControl.setFluents(_fluents);
        }

        public Query getQuery()
        {
            if (accessibleFormulaControl.getFormula() != null && scenario.Steps.Count > 0)
            {

                //if (AlwaysRadioButton.Checked == true)
                //{
                //    return new ScenarioAccessibleAlwaysQuery(ifCheckBox.Checked ? ifFormulaControl.getFormula() : null, accessibleFormulaControl.getFormula(), scenario);
                //}
                //else if (EverRadioButton.Checked == true)
                //{
                //    return new ScenarioAccessibleEverQuery(ifCheckBox.Checked ? ifFormulaControl.getFormula() : null, accessibleFormulaControl.getFormula(), scenario);
                //}
                //else if (TypicallyRadioButton.Checked == true)
                //{
                //    return new ScenarioAccessibleTypicallyQuery(ifCheckBox.Checked ? ifFormulaControl.getFormula() : null, accessibleFormulaControl.getFormula(), scenario);
                //}
            }
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
