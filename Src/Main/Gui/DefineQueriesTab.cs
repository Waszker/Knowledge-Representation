using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KR.Main.Gui.ClauseControls;

namespace KR.Main.Gui
{
    public partial class DefineQueriesTab : UserControl
    {
        UserControl[] queryControls;
        int currentQuery;
        public DefineQueriesTab()
        {
            InitializeComponent();
            chooseQueryComboBox.SelectedIndex = 0;
            currentQuery = 0;
            queryControls = new UserControl[4];
            queryControls[0] = new ExecutableQueryControl();
            queryControls[1] = new ExecutableQueryControl();
            queryControls[2] = new ExecutableQueryControl();
            queryControls[3] = new ExecutableQueryControl();
            
            queryControls[0].Anchor=  AnchorStyles.Top;

            this.defineQueriesPanel.Controls.Add(queryControls[0], 0, 2);
        }
    }
}
