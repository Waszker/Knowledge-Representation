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
            this.checkButton = new System.Windows.Forms.Button();
            this.chooseQueryComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.defineQueriesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // defineQueriesPanel
            // 
            this.defineQueriesPanel.ColumnCount = 1;
            this.defineQueriesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.defineQueriesPanel.Controls.Add(this.checkButton, 0, 3);
            this.defineQueriesPanel.Controls.Add(this.chooseQueryComboBox, 0, 1);
            this.defineQueriesPanel.Controls.Add(this.label1, 0, 0);
            this.defineQueriesPanel.Controls.Add(this.answerLabel, 0, 4);
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
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.Color.MediumOrchid;
            this.checkButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkButton.FlatAppearance.BorderSize = 0;
            this.checkButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrchid;
            this.checkButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.checkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkButton.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkButton.ForeColor = System.Drawing.Color.White;
            this.checkButton.Location = new System.Drawing.Point(25, 389);
            this.checkButton.Margin = new System.Windows.Forms.Padding(25, 3, 25, 3);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(834, 78);
            this.checkButton.TabIndex = 8;
            this.checkButton.Text = "CHECK";
            this.checkButton.UseVisualStyleBackColor = false;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
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
            "always/ever partakes w when Scenario"});
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
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answerLabel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerLabel.Location = new System.Drawing.Point(3, 470);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(878, 91);
            this.answerLabel.TabIndex = 9;
            this.answerLabel.Text = "?";
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel defineQueriesPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox chooseQueryComboBox;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label answerLabel;
    }
}
