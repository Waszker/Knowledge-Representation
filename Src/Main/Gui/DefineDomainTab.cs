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
            clauseControls[1] = new CausesClauseControl();
            this.defineDomainPanel.Controls.Add(clauseControls[0], 0, 2);

            chooseClauseComboBox.SelectedIndex = 0;
        }

        public void setEntities(List<Fluent> fluents, List<Entities.Action> actions, List<Actor> actors)
        {
            ((CausesClauseControl)clauseControls[1]).setActions(actions);
            ((CausesClauseControl)clauseControls[1]).setActors(actors);
        }

        private void chooseClauseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.defineDomainPanel.Controls.Remove(clauseControls[currentClause]);
            currentClause = chooseClauseComboBox.SelectedIndex;
            this.defineDomainPanel.Controls.Add(clauseControls[currentClause], 0, 2);
        }

        private void addClauseButton_Click(object sender, EventArgs e)
        {
            switch(currentClause)
            {
                case 0:
                    break;
                case 1:
                    Causes stmt = ((CausesClauseControl)clauseControls[1]).getClause();
                    clausesListBox.Items.Add(stmt);
                    break;
            }
        }
    }
}
