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
        double hue = 220.0;
        double saturation = 240.0;
        double luminosity;

        public FormulaControl()
        {
            luminosity = 120.0;
            InitializeComponent();
            this.formulaElementComboBox.BackColor = new HSLColor(hue, saturation, luminosity);
            this.formulaElementComboBox.SelectedIndexChanged += new System.EventHandler(this.formulaElementComboBox_SelectedIndexChanged);
        }

        public FormulaControl(List<Fluent> _fluents, double _luminosity)
        {
            InitializeComponent();
            luminosity = _luminosity;
            this.formulaElementComboBox.BackColor = new HSLColor(hue, saturation, _luminosity);
            fluents = _fluents;
            foreach (Fluent f in _fluents)
                this.formulaElementComboBox.Items.Add(f);
            this.formulaElementComboBox.SelectedIndexChanged += new System.EventHandler(this.formulaElementComboBox_SelectedIndexChanged);
        }

        public void setFluents(List<Fluent> _fluents)
        {
            fluents = _fluents;
            foreach (Fluent f in _fluents)
                if (!formulaElementComboBox.Items.Contains(f))
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
                right = new FormulaControl(fluents, luminosity + 35.0);
                this.Panel.Controls.Add(right, 2, 0);

                if (option < 4)
                {
                    left = new FormulaControl(fluents, luminosity + 35.0);
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
                        return new Conjunction(right.getFormula(), left.getFormula());
                    else return null;
                case 1:
                    if (right.getFormula() != null && left.getFormula() != null)
                        return new Alternative(right.getFormula(), left.getFormula());
                    else return null;
                case 2:
                    if (right.getFormula() != null && left.getFormula() != null)
                        return new Implication(left.getFormula(), right.getFormula());
                    else return null;
                case 3:
                    if (right.getFormula() != null && left.getFormula() != null)
                        return new Equivalence(right.getFormula(), left.getFormula());
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
