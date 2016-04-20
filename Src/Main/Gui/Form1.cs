using System.Windows.Forms;

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
            this.mainLayoutPanel.Controls.Remove(tabs[currentTab]);
            currentTab++;
            this.mainLayoutPanel.Controls.Add(tabs[currentTab], 1, 0);
            previousButton.Enabled = true;
            previousButton.Visible = true;
            if (currentTab == 3)
            {
                nextButton.Enabled = false;
                nextButton.Visible = false;
            }

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
