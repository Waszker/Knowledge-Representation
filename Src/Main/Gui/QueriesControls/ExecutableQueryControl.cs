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

namespace KR.Main.Gui.ClauseControls
{
    public partial class ExecutableQueryControl : UserControl
    {
        private Scenario scenario;
        public ExecutableQueryControl()
        {
            InitializeComponent();
        }

        public void setScenario(Scenario _scenario)
        {
            this.ScenarioTextBox.Text = _scenario.ToString();
            scenario = _scenario;
        }

        public Query getQuery()
        {
            if (scenario.Steps.Count>0)
            {
                if (AlwaysRadioButton.Checked == true)
                {
                    return new ScenarioAlwaysExecutableQuery(scenario);
                }
                else if (EverRadioButton.Checked == true)
                {
                    return new ScenarioEverExecutableQuery(scenario);
                }
            }
            return null;
        }
    }
}
