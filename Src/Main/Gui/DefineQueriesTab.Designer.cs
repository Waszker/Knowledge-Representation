namespace KR.Main.Gui
{
    partial class DefineQueriesTab
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
            this.defineQueriesPanel = new System.Windows.Forms.TableLayoutPanel();
            this.chooseQueryComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.showGraphButton = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.Label();
            this.checkQueryButton = new System.Windows.Forms.Button();
            this.defineQueriesPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // defineQueriesPanel
            // 
            this.defineQueriesPanel.ColumnCount = 1;
            this.defineQueriesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.defineQueriesPanel.Controls.Add(this.chooseQueryComboBox, 0, 1);
            this.defineQueriesPanel.Controls.Add(this.label1, 0, 0);
            this.defineQueriesPanel.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.defineQueriesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defineQueriesPanel.Location = new System.Drawing.Point(0, 0);
            this.defineQueriesPanel.Name = "defineQueriesPanel";
            this.defineQueriesPanel.RowCount = 5;
            this.defineQueriesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.defineQueriesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.defineQueriesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.defineQueriesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.defineQueriesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.defineQueriesPanel.Size = new System.Drawing.Size(884, 561);
            this.defineQueriesPanel.TabIndex = 0;
            // 
            // chooseQueryComboBox
            // 
            this.chooseQueryComboBox.BackColor = System.Drawing.Color.White;
            this.chooseQueryComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chooseQueryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseQueryComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chooseQueryComboBox.FormattingEnabled = true;
            this.chooseQueryComboBox.Items.AddRange(new object[] {
            "always/ever executable Scenario",
            "always/ever/typically accessible γ if π when Scenario",
            "always/ever/typically accessible γ if π ",
            "always/ever partakes w when Scenario",
            "always/ever/typically γ after Scenario "});
            this.chooseQueryComboBox.Location = new System.Drawing.Point(60, 77);
            this.chooseQueryComboBox.Margin = new System.Windows.Forms.Padding(60, 10, 60, 10);
            this.chooseQueryComboBox.Name = "chooseQueryComboBox";
            this.chooseQueryComboBox.Size = new System.Drawing.Size(764, 30);
            this.chooseQueryComboBox.TabIndex = 7;
            this.chooseQueryComboBox.SelectedIndexChanged += new System.EventHandler(this.chooseQueryComboBox_SelectedIndexChanged);
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
            this.label1.TabIndex = 6;
            this.label1.Text = "DEFINE QUERIES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.showGraphButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.answer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkQueryButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 389);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.defineQueriesPanel.SetRowSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(878, 169);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // showGraphButton
            // 
            this.showGraphButton.BackColor = System.Drawing.Color.DeepPink;
            this.showGraphButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showGraphButton.FlatAppearance.BorderSize = 0;
            this.showGraphButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumVioletRed;
            this.showGraphButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.showGraphButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showGraphButton.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.showGraphButton.ForeColor = System.Drawing.Color.White;
            this.showGraphButton.Location = new System.Drawing.Point(464, 3);
            this.showGraphButton.Margin = new System.Windows.Forms.Padding(25, 3, 25, 3);
            this.showGraphButton.Name = "showGraphButton";
            this.showGraphButton.Size = new System.Drawing.Size(389, 78);
            this.showGraphButton.TabIndex = 11;
            this.showGraphButton.Text = "SHOW GRAPH";
            this.showGraphButton.UseVisualStyleBackColor = false;
            this.showGraphButton.Click += new System.EventHandler(this.showGraphButton_Click);
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.answer, 2);
            this.answer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answer.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answer.Location = new System.Drawing.Point(3, 84);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(872, 85);
            this.answer.TabIndex = 10;
            this.answer.Text = "?";
            this.answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkQueryButton
            // 
            this.checkQueryButton.BackColor = System.Drawing.Color.MediumOrchid;
            this.checkQueryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkQueryButton.FlatAppearance.BorderSize = 0;
            this.checkQueryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.checkQueryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.checkQueryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkQueryButton.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkQueryButton.ForeColor = System.Drawing.Color.White;
            this.checkQueryButton.Location = new System.Drawing.Point(25, 3);
            this.checkQueryButton.Margin = new System.Windows.Forms.Padding(25, 3, 25, 3);
            this.checkQueryButton.Name = "checkQueryButton";
            this.checkQueryButton.Size = new System.Drawing.Size(389, 78);
            this.checkQueryButton.TabIndex = 9;
            this.checkQueryButton.Text = "CHECK";
            this.checkQueryButton.UseVisualStyleBackColor = false;
            this.checkQueryButton.Click += new System.EventHandler(this.checkQueryButton_Click);
            // 
            // DefineQueriesTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.defineQueriesPanel);
            this.Name = "DefineQueriesTab";
            this.Size = new System.Drawing.Size(884, 561);
            this.defineQueriesPanel.ResumeLayout(false);
            this.defineQueriesPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel defineQueriesPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox chooseQueryComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button showGraphButton;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Button checkQueryButton;
    }
}
