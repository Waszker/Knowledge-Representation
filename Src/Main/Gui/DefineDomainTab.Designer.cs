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
            this.defineDomainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defineDomainPanel.Location = new System.Drawing.Point(0, 0);
            this.defineDomainPanel.Name = "defineDomainPanel";
            this.defineDomainPanel.RowCount = 5;
            this.defineDomainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.defineDomainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.defineDomainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.defineDomainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.defineDomainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.defineDomainPanel.Size = new System.Drawing.Size(555, 361);
            this.defineDomainPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "DEFINE DOMAIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chooseClauseComboBox
            // 
            this.chooseClauseComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chooseClauseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseClauseComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chooseClauseComboBox.FormattingEnabled = true;
            this.chooseClauseComboBox.Items.AddRange(new object[] {
            "initially α",
            "α after (A1,W1),...,(An,Wn) ",
            "(A,W) causes α if π ",
            "(A,W) causes α",
            "impossible (A,W) if π",
            "observable α after (A1,W1),...,(An,Wn)",
            "(A,W) releases f if π ",
            "(A,W) typically causes α if π ",
            "typically α after (A1,W1),...,(An,Wn)",
            "always α",
            "(A,W) preserves f if π"});
            this.chooseClauseComboBox.Location = new System.Drawing.Point(10, 53);
            this.chooseClauseComboBox.Margin = new System.Windows.Forms.Padding(10);
            this.chooseClauseComboBox.Name = "chooseClauseComboBox";
            this.chooseClauseComboBox.Size = new System.Drawing.Size(535, 30);
            this.chooseClauseComboBox.TabIndex = 2;
            // 
            // addClauseButton
            // 
            this.addClauseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addClauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addClauseButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addClauseButton.Location = new System.Drawing.Point(202, 190);
            this.addClauseButton.Name = "addClauseButton";
            this.addClauseButton.Size = new System.Drawing.Size(150, 48);
            this.addClauseButton.TabIndex = 3;
            this.addClauseButton.Text = "ADD CLAUSE";
            this.addClauseButton.UseVisualStyleBackColor = true;
            // 
            // clausesListBox
            // 
            this.clausesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clausesListBox.FormattingEnabled = true;
            this.clausesListBox.HorizontalScrollbar = true;
            this.clausesListBox.Location = new System.Drawing.Point(3, 244);
            this.clausesListBox.Name = "clausesListBox";
            this.clausesListBox.Size = new System.Drawing.Size(549, 114);
            this.clausesListBox.TabIndex = 4;
            // 
            // DefineDomainTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.defineDomainPanel);
            this.Name = "DefineDomainTab";
            this.Size = new System.Drawing.Size(555, 361);
            this.defineDomainPanel.ResumeLayout(false);
            this.defineDomainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel defineDomainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox chooseClauseComboBox;
        private System.Windows.Forms.Button addClauseButton;
        private System.Windows.Forms.ListBox clausesListBox;
    }
}
