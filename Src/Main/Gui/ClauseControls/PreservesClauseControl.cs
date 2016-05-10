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
    public partial class PreservesClauseControl : UserControl
    {
        public PreservesClauseControl()
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
            foreach (Actor a in _actors)
                ActorsCheckedListBox.Items.Add(a);
            //TODO: ADD EPSILON
        }

        public void setFluents(List<Fluent> _fluents)
        {
            fluentComboBox.Items.Clear();
            foreach (Fluent f in _fluents)
                fluentComboBox.Items.Add(f);
            if (_fluents.Count > 0)
                fluentComboBox.SelectedIndex = 0;

            this.conditionFormulaControl.setFluents(_fluents);
        }

        public Preserves getClause()
        {
            if (ActionComboBox.SelectedIndex == -1 || ActorsCheckedListBox.SelectedIndices.Count == 0 || fluentComboBox.SelectedIndex == -1 || conditionFormulaControl.getFormula() == null)
                return null;
            return new Preserves((Entities.Action)ActionComboBox.SelectedItem, ExclusionCheckBox.Checked, ActorsCheckedListBox.CheckedItems.Cast<Actor>().ToList(), (Fluent)fluentComboBox.SelectedItem, conditionFormulaControl.getFormula());
        }
    }
}