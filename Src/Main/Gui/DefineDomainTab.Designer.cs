namespace KR.Main.Gui
{
    partial class DefineDomainTab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.defineDomainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.chooseClauseComboBox = new System.Windows.Forms.ComboBox();
            this.addClauseButton = new System.Windows.Forms.Button();
            this.clausesListBox = new System.Windows.Forms.ListBox();
            this.deleteClauseButton = new System.Windows.Forms.Button();
            this.defineDomainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // defineDomainPanel
            // 
            this.defineDomainPanel.ColumnCount = 1;
            this.defineDomainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.defineDomainPanel.Controls.Add(this.label1, 0, 0);
            this.defineDomainPanel.Controls.Add(this.chooseClauseComboBox, 0, 1);
            this.defineDomainPanel.Controls.Add(this.addClauseButton, 0, 3);
            this.defineDomainPanel.Controls.Add(this.clausesListBox, 0, 4);
            this.defineDomainPanel.Controls.Add(this.deleteClauseButton, 0, 5);
            this.defineDomainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defineDomainPanel.Location = new System.Drawing.Point(0, 0);
            this.defineDomainPanel.Name = "defineDomainPanel";
            this.defineDomainPanel.RowCount = 6;
            this.defineDomainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.defineDomainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.defineDomainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.defineDomainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.defineDomainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.defineDomainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.defineDomainPanel.Size = new System.Drawing.Size(884, 561);
            this.defineDomainPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(878, 62);
            this.label1.TabIndex = 5;
            this.label1.Text = "DEFINE DOMAIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chooseClauseComboBox
            // 
            this.chooseClauseComboBox.BackColor = System.Drawing.Color.White;
            this.chooseClauseComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chooseClauseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseClauseComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chooseClauseComboBox.FormattingEnabled = true;
            this.chooseClauseComboBox.Items.AddRange(new object[] {
            "initially α",
            "(A,W) causes α if π ",
            "(A,W) typically causes α if π ",
            "(A,W) releases f if π ",
            "(A,W) preserves f if π",
            "always α",
            "impossible (A,W) if π",
            "α after (A1,W1),...,(An,Wn) ",
            "typically α after (A1,W1),...,(An,Wn)",
            "observable α after (A1,W1),...,(An,Wn)"});
            this.chooseClauseComboBox.Location = new System.Drawing.Point(60, 77);
            this.chooseClauseComboBox.Margin = new System.Windows.Forms.Padding(60, 10, 60, 10);
            this.chooseClauseComboBox.Name = "chooseClauseComboBox";
            this.chooseClauseComboBox.Size = new System.Drawing.Size(764, 30);
            this.chooseClauseComboBox.TabIndex = 2;
            this.chooseClauseComboBox.SelectedIndexChanged += new System.EventHandler(this.chooseClauseComboBox_SelectedIndexChanged);
            // 
            // addClauseButton
            // 
            this.addClauseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addClauseButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.addClauseButton.FlatAppearance.BorderSize = 0;
            this.addClauseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.addClauseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.addClauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addClauseButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addClauseButton.ForeColor = System.Drawing.Color.White;
            this.addClauseButton.Location = new System.Drawing.Point(357, 294);
            this.addClauseButton.Name = "addClauseButton";
            this.addClauseButton.Size = new System.Drawing.Size(170, 50);
            this.addClauseButton.TabIndex = 3;
            this.addClauseButton.Text = "ADD CLAUSE";
            this.addClauseButton.UseVisualStyleBackColor = false;
            this.addClauseButton.Click += new System.EventHandler(this.addClauseButton_Click);
            // 
            // clausesListBox
            // 
            this.clausesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clausesListBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clausesListBox.FormattingEnabled = true;
            this.clausesListBox.HorizontalScrollbar = true;
            this.clausesListBox.ItemHeight = 20;
            this.clausesListBox.Location = new System.Drawing.Point(3, 350);
            this.clausesListBox.Name = "clausesListBox";
            this.clausesListBox.Size = new System.Drawing.Size(878, 162);
            this.clausesListBox.TabIndex = 4;
            // 
            // deleteClauseButton
            // 
            this.deleteClauseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.deleteClauseButton.BackColor = System.Drawing.Color.Silver;
            this.deleteClauseButton.FlatAppearance.BorderSize = 0;
            this.deleteClauseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.deleteClauseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.deleteClauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteClauseButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteClauseButton.ForeColor = System.Drawing.Color.White;
            this.deleteClauseButton.Location = new System.Drawing.Point(357, 518);
            this.deleteClauseButton.Name = "deleteClauseButton";
            this.deleteClauseButton.Size = new System.Drawing.Size(170, 40);
            this.deleteClauseButton.TabIndex = 6;
            this.deleteClauseButton.Text = "DELETE CLAUSE";
            this.deleteClauseButton.UseVisualStyleBackColor = false;
            this.deleteClauseButton.Click += new System.EventHandler(this.deleteClauseButton_Click);
            // 
            // DefineDomainTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.defineDomainPanel);
            this.Name = "DefineDomainTab";
            this.Size = new System.Drawing.Size(884, 561);
            this.defineDomainPanel.ResumeLayout(false);
            this.defineDomainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel defineDomainPanel;
        private System.Windows.Forms.ComboBox chooseClauseComboBox;
        private System.Windows.Forms.Button addClauseButton;
        private System.Windows.Forms.ListBox clausesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteClauseButton;
    }
}
