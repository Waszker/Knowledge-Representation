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
        public DefineDomainTab()
        {
            InitializeComponent();
            chooseClauseComboBox.SelectedIndex = 0;
        }
    }
}
