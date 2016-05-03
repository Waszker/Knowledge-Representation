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
using KR.Main.Entities.Conditions;

namespace KR.Main.Gui.ClauseControls
{
    public partial class FormulaControl : UserControl
    {
        FormulaControl left;
        FormulaControl right;
        List<Fluent> fluents;
        public FormulaControl()
        {
            InitializeComponent();
            this.formulaElementComboBox.SelectedIndexChanged += new System.EventHandler(this.formulaElementComboBox_SelectedIndexChanged);
        }

        public FormulaControl(List<Fluent> _fluents)
        {
            InitializeComponent();
            fluents = _fluents;
            foreach (Fluent f in _fluents)
                this.formulaElementComboBox.Items.Add(f);
            this.formulaElementComboBox.SelectedIndexChanged += new System.EventHandler(this.formulaElementComboBox_SelectedIndexChanged);
        }

        public void setFluents(List<Fluent> _fluents)
        {
            fluents = _fluents;
            foreach (Fluent f in _fluents)
                this.formulaElementComboBox.Items.Add(f);
        }

        private void formulaElementComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (left != null)
                this.Panel.Controls.Remove(left);
            if (right != null)
                this.Panel.Controls.Remove(right);
            left = right = null;
            int option = this.formulaElementComboBox.SelectedIndex;
            if (option < 5)
            {
                right = new FormulaControl(fluents);
                this.Panel.Controls.Add(right, 2, 0);

                if (option < 4)
                {
                    left = new FormulaControl(fluents);
                    this.Panel.Controls.Add(left, 0, 0);
                }
            }
        }

        public ICondition getFormula()
        {
            switch (this.formulaElementComboBox.SelectedIndex)
            {
                case -1:
                    return null;
                case 0:
                    if (right.getFormula() != null && left.getFormula() != null)
                        return new Conjuction(right.getFormula(), left.getFormula());
                    else return null;
                case 1:
                    if (right.getFormula() != null && left.getFormula() != null)
                        return new Conjuction(right.getFormula(), left.getFormula());
                    else return null;
                case 2:
                    if (right.getFormula() != null && left.getFormula() != null)
                        return new Conjuction(right.getFormula(), left.getFormula());
                    else return null;
                case 3:
                    if (right.getFormula() != null && left.getFormula() != null)
                        return new Conjuction(right.getFormula(), left.getFormula());
                    else return null;
                case 4:
                    if (right.getFormula() != null)
                        return new Negation(right.getFormula());
                    else return null;
                default:
                    return (Fluent)this.formulaElementComboBox.SelectedItem;
            }
        }
    }
}
