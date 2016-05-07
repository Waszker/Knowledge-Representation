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
    }
}
