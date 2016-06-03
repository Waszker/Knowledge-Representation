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
using KR.Main.Entities.Statements;

namespace KR.Main.Gui.ClauseControls
{
    public partial class ImpossibleClauseControl : UserControl
    {
        public ImpossibleClauseControl()
        {
            InitializeComponent();
        }
        public void setActions(List<Entities.Action> _actions)
        {
            ActionComboBox.Items.Clear();
            foreach (Entities.Action a in _actions)
                ActionComboBox.Items.Add(a);
            if (_actions.Count > 0)
                ActionComboBox.SelectedIndex = 0;
        }

        public void setActors(List<Actor> _actors)
        {
            ActorsCheckedListBox.Items.Clear();
            ActorsCheckedListBox.Items.Add(new Actor("ϵ"));
            foreach (Actor a in _actors)
                ActorsCheckedListBox.Items.Add(a);
        }

        public void setFluents(List<Fluent> _fluents)
        {
            this.conditionFormulaControl.setFluents(_fluents);
        }

        public Impossible getClause()
        {
            if (ActionComboBox.SelectedIndex == -1 || ActorsCheckedListBox.SelectedIndices.Count == 0 || (ifCheckBox.Checked && conditionFormulaControl.getFormula() == null))
                return null;
            return new Impossible((Entities.Action)ActionComboBox.SelectedItem, ExclusionCheckBox.Checked, ActorsCheckedListBox.CheckedItems.Cast<Actor>().ToList(), ifCheckBox.Checked ? conditionFormulaControl.getFormula() : null);
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