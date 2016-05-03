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

namespace KR.Main.Gui
{
    public partial class InitiallyClauseControl : UserControl
    {
        public InitiallyClauseControl()
        {
            InitializeComponent();
        }

        public void setFluents(List<Fluent> _fluents)
        {
            this.initialFormulaControl.setFluents(_fluents);
        }

        public Initially getClause()
        {
            if (initialFormulaControl.getFormula() == null)
                return null;
            return new Initially(initialFormulaControl.getFormula());
        }
    }
}
