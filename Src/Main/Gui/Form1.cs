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
            switch(currentTab)
            {
                case 0: 
                    List<Fluent> fluentList = ((DefineEntitiesTab)tabs[0]).getFluents();
                    List<Entities.Action> actionList = ((DefineEntitiesTab)tabs[0]).getActions();
                    List<Actor> actorList = ((DefineEntitiesTab)tabs[0]).getActors();
                    ((DefineDomainTab)tabs[1]).setEntities(fluentList, actionList, actorList);
                    break;
                case 1: 
                    World.Instance.SetFluents(((DefineEntitiesTab)tabs[0]).getFluents());
                    World.Instance.SetActions(((DefineEntitiesTab)tabs[0]).getActions());
                    World.Instance.SetActors(((DefineEntitiesTab)tabs[0]).getActors());
                    World.Instance.SetDomain(((DefineDomainTab)tabs[1]).getDomain());
                    World.Instance.Build();
                    ((DefineScenarioTab)tabs[2]).setActionsAndActors(((DefineEntitiesTab)tabs[0]).getActions(), ((DefineEntitiesTab)tabs[0]).getActors());
                    ((DefineScenarioTab)tabs[2]).cleanScenario();
                    break;
                case 2:
                    List<Tuple<Entities.Action, Actor>> scenario = ((DefineScenarioTab)tabs[2]).getScenario();
                    ((DefineScenarioTab)tabs[2]).cleanScenario();
                    nextButton.Enabled = false;
                    nextButton.Visible = false;
                    break;
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
