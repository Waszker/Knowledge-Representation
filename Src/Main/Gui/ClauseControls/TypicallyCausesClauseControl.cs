using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KR.Main.Entities.Statements;
using KR.Main.Entities;

namespace KR.Main.Gui.ClauseControls
{
    public partial class TypicallyCausesClauseControl : UserControl
    {
        public TypicallyCausesClauseControl()
        {
            InitializeComponent();
        }

        public void setActions(List<Entities.Action> _actions)
        {
            foreach (Entities.Action a in _actions)
                ActionComboBox.Items.Add(a);
            if (_actions.Count > 0)
                ActionComboBox.SelectedIndex = 0;
        }

        public void setActors(List<Actor> _actors)
        {
            foreach (Actor a in _actors)
                ActorsCheckedListBox.Items.Add(a);
            //TODO: ADD EPSILON
        }

        public void setFluents(List<Fluent> _fluents)
        {
            this.effectFormulaControl.setFluents(_fluents);
            this.conditionFormulaControl.setFluents(_fluents);
        }

        public TypicallyCauses getClause()
        {
            if (ActionComboBox.SelectedIndex == -1 || ActorsCheckedListBox.SelectedIndices.Count == 0 || effectFormulaControl.getFormula() == null)
                return null;
            return new TypicallyCauses((Entities.Action)ActionComboBox.SelectedItem, ExclusionCheckBox.Checked, ActorsCheckedListBox.CheckedItems.Cast<Actor>().ToList(), effectFormulaControl.getFormula(), ifCheckBox.Checked ? conditionFormulaControl.getFormula() : null);
        }

        private void ifCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ifCheckBox.Checked == true)
                conditionFormulaControl.Enabled = true;
            else
                conditionFormulaControl.Enabled = false;
        }
    }
}
