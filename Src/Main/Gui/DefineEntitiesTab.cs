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

        public DefineEntitiesTab()
        {
            InitializeComponent();
            _fluents = new List<Fluent>();
        }

        public List<Fluent> getFluents()
        {
            return _fluents;
        }

        private void addFluentButton_Click(object sender, EventArgs e)
        {
            string text = fluentTextBox.Text;
            if(text.Length>0)
            {
                Fluent newFluent = new Fluent(text);
                if (!_fluents.Any(f => f.Name == newFluent.Name))
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
    }
}



