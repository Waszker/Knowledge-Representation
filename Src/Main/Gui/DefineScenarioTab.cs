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

namespace KR.Main.Gui
{
    public partial class DefineScenarioTab : UserControl
    {
        List<Tuple<Entities.Action, Actor>> scenario;

        public DefineScenarioTab()
        {
            InitializeComponent();
            scenario = new List<Tuple<Entities.Action, Actor>>();
        }
        
        public void setActionsAndActors(List<Entities.Action> actions, List<Actor> actors)
        {
            actionComboBox.Items.Clear();
            foreach (Entities.Action a in actions)
                actionComboBox.Items.Add(a);
            if (actions.Count>0)
                actionComboBox.SelectedIndex = 0;

            actorComboBox.Items.Clear();
            foreach (Actor a in actors)
                actorComboBox.Items.Add(a);
            if (actors.Count>0)
                actorComboBox.SelectedIndex = 0;
        }

        public void cleanScenario()
        {
            scenario.Clear();
            scenarioStepsListBox.Items.Clear();
        }

        public Scenario getScenario()
        {
            Scenario _scenario = new Scenario();
            foreach(Tuple<Entities.Action, Actor> step in scenario)
            {
                ScenarioStep s = new ScenarioStep(step.Item1, step.Item2);
                _scenario.AddScenarioStep(s);
            }
            return _scenario;
        }

        private void addStep_Click(object sender, EventArgs e)
        {
            Entities.Action action = (Entities.Action)actionComboBox.SelectedItem;
            Actor actor = (Actor)actorComboBox.SelectedItem;
            if (action != null && actor != null)
            {
                scenario.Add(new Tuple<Entities.Action, Actor>(action, actor));
                scenarioStepsListBox.Items.Add("(" + action.ToString() + ", " + actor.ToString() + ")");
            }
        }

        private void deleteStep_Click(object sender, EventArgs e)
        {
            int step = scenarioStepsListBox.SelectedIndex;
            if (step >= 0)
            {
                scenario.RemoveAt(step);
                scenarioStepsListBox.Items.RemoveAt(step);
            }
        }
    }
}
