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
using KR.Main.Gui.ClauseControls;

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
            clauseControls[2] = new TypicallyCausesClauseControl();
            clauseControls[3] = new ReleasesClauseControl();
            clauseControls[4] = new PreservesClauseControl();
            clauseControls[5] = new AlwaysClauseControl();
            clauseControls[6] = new ImpossibleClauseControl();
            clauseControls[7] = new AfterClauseControl();
            clauseControls[8] = new TypicallyAfterClauseControl();
            clauseControls[9] = new ObservableClauseControl();
            this.defineDomainPanel.Controls.Add(clauseControls[0], 0, 2);

            chooseClauseComboBox.SelectedIndex = 0;
        }

        public void setEntities(List<Fluent> fluents, List<Entities.Action> actions, List<Actor> actors)
        {
            ((InitiallyClauseControl)clauseControls[0]).setFluents(fluents);
            ((CausesClauseControl)clauseControls[1]).setActions(actions);
            ((CausesClauseControl)clauseControls[1]).setActors(actors);
            ((CausesClauseControl)clauseControls[1]).setFluents(fluents);
        }

        private void chooseClauseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.defineDomainPanel.Controls.Remove(clauseControls[currentClause]);
            currentClause = chooseClauseComboBox.SelectedIndex;
            this.defineDomainPanel.Controls.Add(clauseControls[currentClause], 0, 2);
        }

        private void addClauseButton_Click(object sender, EventArgs e)
        {
            switch (currentClause)
            {
                case 0:
                    {
                        Initially stmt = ((InitiallyClauseControl)clauseControls[currentClause]).getClause();
                        if (stmt != null)
                            clausesListBox.Items.Add(stmt);
                        break;
                    }
                case 1:
                    {
                        Causes stmt = ((CausesClauseControl)clauseControls[currentClause]).getClause();
                        if (stmt != null)
                            clausesListBox.Items.Add(stmt);
                        break;
                    }
                case 2:
                    {
                        TypicallyCauses stmt = ((TypicallyCausesClauseControl)clauseControls[currentClause]).getClause();
                        if (stmt != null)
                            clausesListBox.Items.Add(stmt);
                        break;
                    }
                /*case 3:
                    {
                        Releases stmt = ((ReleasesClauseControl)clauseControls[currentClause]).getClause();
                        if (stmt != null)
                            clausesListBox.Items.Add(stmt);
                        break;
                    }
                case 4:
                    {
                        Preserves stmt = ((PreservesClauseControl)clauseControls[currentClause]).getClause();
                        if (stmt != null)
                            clausesListBox.Items.Add(stmt);
                        break;
                    }
                case 5:
                    {
                        Always stmt = ((AlwaysClauseControl)clauseControls[currentClause]).getClause();
                        if (stmt != null)
                            clausesListBox.Items.Add(stmt);
                        break;
                    }
                case 6:
                    {
                        Impossible stmt = ((ImpossibleClauseControl)clauseControls[currentClause]).getClause();
                        if (stmt != null)
                            clausesListBox.Items.Add(stmt);
                        break;
                    }
                case 7:
                    {
                        After stmt = ((AfterClauseControl)clauseControls[currentClause]).getClause();
                        if (stmt != null)
                            clausesListBox.Items.Add(stmt);
                        break;
                    }
                case 8:
                    {
                        TypicallyAfter stmt = ((TypicallyAfterClauseControl)clauseControls[currentClause]).getClause();
                        if (stmt != null)
                            clausesListBox.Items.Add(stmt);
                        break;
                    }
                case 9:
                    {
                        Observable stmt = ((ObservableClauseControl)clauseControls[currentClause]).getClause();
                        if (stmt != null)
                            clausesListBox.Items.Add(stmt);
                        break;
                    }*/
            }
        }
    }
}
