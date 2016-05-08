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
    public partial class AccessibleQueryControl : UserControl
    {
        public AccessibleQueryControl()
        {
            InitializeComponent();
        }

        public void setFluents(List<Fluent> _fluents)
        {
            this.accessibleFormulaControl.setFluents(_fluents);
            this.ifFormulaControl.setFluents(_fluents);
        }

        public Query getQuery()
        {
            if (accessibleFormulaControl.getFormula() != null)
            {

                if (AlwaysRadioButton.Checked == true)
                {
                    return new AccessibleAlwaysQuery(ifCheckBox.Checked ? ifFormulaControl.getFormula() : null, accessibleFormulaControl.getFormula());
                }
                else if (EverRadioButton.Checked == true)
                {
                    return new AccessibleEverQuery(ifCheckBox.Checked ? ifFormulaControl.getFormula() : null, accessibleFormulaControl.getFormula());
                }
                else if (TypicallyRadioButton.Checked == true)
                {
                    return new AccessibleTypicallyQuery(ifCheckBox.Checked ? ifFormulaControl.getFormula() : null, accessibleFormulaControl.getFormula());
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
