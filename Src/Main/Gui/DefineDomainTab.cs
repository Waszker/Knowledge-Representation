using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR.Main.Gui
{
    public partial class DefineDomainTab : UserControl
    {
        UserControl[] clauseControls;
        int currentClause;

        public DefineDomainTab()
        {
            InitializeComponent();

            currentClause = 0;
            clauseControls = new UserControl[10];
            clauseControls[0] = new InitiallyClauseControl();
            this.defineDomainPanel.Controls.Add(clauseControls[0], 0, 2);

            chooseClauseComboBox.SelectedIndex = 0;
        }
    }
}
