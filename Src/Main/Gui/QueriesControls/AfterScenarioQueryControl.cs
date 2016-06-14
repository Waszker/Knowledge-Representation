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
    public partial class AfterScenarioQueryControl : UserControl
    {
        private Scenario scenario;
        public AfterScenarioQueryControl()
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
            this.gammaFormulaControl.setFluents(_fluents);
            this.ifFormulaControl.setFluents(_fluents);
        }

        public Query getQuery()
        {
            if (gammaFormulaControl.getFormula() != null && scenario.Steps.Count > 0)
            {

                if (AlwaysRadioButton.Checked == true)
                {
                    return new AfterScenarioAlwaysQuery(ifCheckBox.Checked ? ifFormulaControl.getFormula() : null, gammaFormulaControl.getFormula(), scenario);
                }
                else if (EverRadioButton.Checked == true)
                {
                    return new AfterScenarioEverQuery(ifCheckBox.Checked ? ifFormulaControl.getFormula() : null, gammaFormulaControl.getFormula(), scenario);
                }
                else if (TypicallyRadioButton.Checked == true)
                {
                    return new AfterScenarioTypicallyQuery(ifCheckBox.Checked ? ifFormulaControl.getFormula() : null, gammaFormulaControl.getFormula(), scenario);
                }
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
