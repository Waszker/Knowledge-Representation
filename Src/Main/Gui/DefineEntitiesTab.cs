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
    public partial class DefineEntitiesTab : UserControl
    {
        private List<Fluent> _fluents;
        private List<Entities.Action> _actions;
        private List<Actor> _actors;

        public DefineEntitiesTab()
        {
            InitializeComponent();
            _fluents = new List<Fluent>();
            _actions = new List<Entities.Action>();
            _actors = new List<Actor>();
        }

        public List<Fluent> getFluents()
        {
            return _fluents;
        }

        public List<Actor> getActors()
        {
            return _actors;
        }

        public List<Entities.Action> getActions()
        {
            return _actions;
        }

        private void addFluentButton_Click(object sender, EventArgs e)
        {
            string text = fluentTextBox.Text;
            if(text.Length>0)
            {
                Fluent newFluent = new Fluent(text);
                if (!_fluents.Contains(newFluent))
                {
                    fluentListBox.Items.Add(newFluent);
                    _fluents.Add(newFluent);
                }
                fluentTextBox.Text = string.Empty;
            }
        }

        private void deleteFluentButton_Click(object sender, EventArgs e)
        {
            if(fluentListBox.SelectedIndex>=0)
            {
                Fluent selectedFluent = (Fluent)fluentListBox.SelectedItem;
                _fluents.Remove(selectedFluent);
                fluentListBox.Items.Remove(selectedFluent);
            }
        }

        private void addActionButton_Click(object sender, EventArgs e)
        {
            string text = actionTextBox.Text;
            if (text.Length > 0)
            {
                Entities.Action newAction = new Entities.Action(text);
                if (!_actions.Contains(newAction))
                {
                    actionListBox.Items.Add(newAction);
                    _actions.Add(newAction);
                }
                actionTextBox.Text = string.Empty;
            }
        }

        private void deleteActionButton_Click(object sender, EventArgs e)
        {
            if (actionListBox.SelectedIndex >= 0)
            {
                Entities.Action selectedAction = (Entities.Action)actionListBox.SelectedItem;
                _actions.Remove(selectedAction);
                actionListBox.Items.Remove(selectedAction);
            }
        }

        private void addActorButton_Click(object sender, EventArgs e)
        {
            string text = actorTextBox.Text;
            if (text.Length > 0)
            {
                Actor newActor = new Actor(text);
                if (!_actors.Contains(newActor))
                {
                    actorListBox.Items.Add(newActor);
                    _actors.Add(newActor);
                }
                actorTextBox.Text = string.Empty;
            }
        }

        private void deleteActorButton_Click(object sender, EventArgs e)
        {
            if (actorListBox.SelectedIndex >= 0)
            {
                Actor selectedActor = (Actor)actorListBox.SelectedItem;
                _actors.Remove(selectedActor);
                actorListBox.Items.Remove(selectedActor);
            }
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            _actors.Clear();
            actorListBox.Items.Clear();
            _actions.Clear();
            actionListBox.Items.Clear();
            _fluents.Clear();
            fluentListBox.Items.Clear();
        }
    }
}



