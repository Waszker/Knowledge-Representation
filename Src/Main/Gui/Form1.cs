using KR.Main.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using KR.Main.Engine;

namespace KR.Main.Gui
{
    public partial class Form1 : Form
    {
        UserControl[] tabs;
        int currentTab;

        public Form1()
        {
            InitializeComponent();
            tabs = new UserControl[4];
            tabs[0] = new DefineEntitiesTab();
            tabs[1] = new DefineDomainTab();
            tabs[2] = new DefineScenarioTab();
            tabs[3] = new DefineQueriesTab();

            tabs[0].Dock = DockStyle.Fill;
            tabs[1].Dock = DockStyle.Fill;
            tabs[2].Dock = DockStyle.Fill;
            tabs[3].Dock = DockStyle.Fill;

            currentTab = 0;
            previousButton.Enabled = false;
            previousButton.Visible = false;
            this.mainLayoutPanel.Controls.Add(tabs[0], 1, 0);
        }

        private void nextButton_Click(object sender, System.EventArgs e)
        {
            bool excepion = false;
            switch (currentTab)
            {
                case 0:
                    List<Fluent> fluentList = ((DefineEntitiesTab)tabs[0]).getFluents();
                    List<Entities.Action> actionList = ((DefineEntitiesTab)tabs[0]).getActions();
                    List<Actor> actorList = ((DefineEntitiesTab)tabs[0]).getActors();
                    ((DefineDomainTab)tabs[1]).ResetAll();
                    ((DefineQueriesTab)tabs[3]).ResetAll();
                    ((DefineDomainTab)tabs[1]).setEntities(fluentList, actionList, actorList);
                    ((DefineScenarioTab)tabs[2]).setActionsAndActors(actionList, actorList);
                    ((DefineQueriesTab)tabs[3]).setFluentsAndActors(fluentList, actorList);
                    ((DefineDomainTab)tabs[1]).cleanDomain();
                    World.Instance.SetFluents(fluentList);
                    World.Instance.SetActions(actionList);
                    World.Instance.SetActors(actorList);
                    break;
                case 1:
                    World.Instance.SetDomain(((DefineDomainTab)tabs[1]).getDomain());
                    if (((DefineDomainTab)tabs[1]).definedInitially())
                    {
                        try { World.Instance.Build(); }
                        catch (Exception ex)
                        {
                            excepion = true;
                        }
                    }

                    ((DefineScenarioTab)tabs[2]).cleanScenario();
                    break;
                case 2:
                    ((DefineQueriesTab)tabs[3]).setScenario(((DefineScenarioTab)tabs[2]).getScenario());
                    nextButton.Enabled = false;
                    nextButton.Visible = false;
                    break;
            }

            if (currentTab == 0 && ((((DefineEntitiesTab)tabs[0]).getFluents().Count == 0) || (((DefineEntitiesTab)tabs[0]).getActions().Count == 0) || (((DefineEntitiesTab)tabs[0]).getActors().Count == 0)))
            {
                MessageBox.Show("Specify fluents, actions and actors!", "Stop!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (excepion)
            {
                MessageBox.Show("There can be only one initial state!", "Stop!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.mainLayoutPanel.Controls.Remove(tabs[currentTab]);
            currentTab++;
            this.mainLayoutPanel.Controls.Add(tabs[currentTab], 1, 0);
            previousButton.Enabled = true;
            previousButton.Visible = true;
        }

        private void previousButton_Click(object sender, System.EventArgs e)
        {
            this.mainLayoutPanel.Controls.Remove(tabs[currentTab]);
            currentTab--;
            this.mainLayoutPanel.Controls.Add(tabs[currentTab], 1, 0);
            nextButton.Enabled = true;
            nextButton.Visible = true;
            if (currentTab == 0)
            {
                previousButton.Enabled = false;
                previousButton.Visible = false;
            }
        }
    }
}
