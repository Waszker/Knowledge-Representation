namespace KR.Main.Gui.ClauseControls
{
    partial class TypicallyCausesClauseControl
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
            this.CausesClausePanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ActionComboBox = new System.Windows.Forms.ComboBox();
            this.ActorsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.ExclusionCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.effectFormulaControl = new KR.Main.Gui.ClauseControls.FormulaControl();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.conditionFormulaControl = new KR.Main.Gui.ClauseControls.FormulaControl();
            this.ifCheckBox = new System.Windows.Forms.CheckBox();
            this.CausesClausePanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CausesClausePanel
            // 
            this.CausesClausePanel.ColumnCount = 1;
            this.CausesClausePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CausesClausePanel.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.CausesClausePanel.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.CausesClausePanel.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.CausesClausePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CausesClausePanel.Location = new System.Drawing.Point(0, 0);
            this.CausesClausePanel.Margin = new System.Windows.Forms.Padding(0);
            this.CausesClausePanel.Name = "CausesClausePanel";
            this.CausesClausePanel.RowCount = 3;
            this.CausesClausePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.CausesClausePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.CausesClausePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.CausesClausePanel.Size = new System.Drawing.Size(878, 162);
            this.CausesClausePanel.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ActionComboBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ActorsCheckedListBox, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.ExclusionCheckBox, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(878, 48);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(368, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 48);
            this.label3.TabIndex = 3;
            this.label3.Text = "performed by";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "action";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ActionComboBox
            // 
            this.ActionComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionComboBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ActionComboBox.FormattingEnabled = true;
            this.ActionComboBox.Location = new System.Drawing.Point(108, 7);
            this.ActionComboBox.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.ActionComboBox.Name = "ActionComboBox";
            this.ActionComboBox.Size = new System.Drawing.Size(257, 32);
            this.ActionComboBox.TabIndex = 1;
            // 
            // ActorsCheckedListBox
            // 
            this.ActorsCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActorsCheckedListBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ActorsCheckedListBox.FormattingEnabled = true;
            this.ActorsCheckedListBox.HorizontalScrollbar = true;
            this.ActorsCheckedListBox.Location = new System.Drawing.Point(581, 3);
            this.ActorsCheckedListBox.Name = "ActorsCheckedListBox";
            this.ActorsCheckedListBox.Size = new System.Drawing.Size(294, 42);
            this.ActorsCheckedListBox.TabIndex = 4;
            // 
            // ExclusionCheckBox
            // 
            this.ExclusionCheckBox.AutoSize = true;
            this.ExclusionCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExclusionCheckBox.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExclusionCheckBox.Location = new System.Drawing.Point(511, 3);
            this.ExclusionCheckBox.Name = "ExclusionCheckBox";
            this.ExclusionCheckBox.Size = new System.Drawing.Size(64, 42);
            this.ExclusionCheckBox.TabIndex = 5;
            this.ExclusionCheckBox.Text = "¬";
            this.ExclusionCheckBox.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.effectFormulaControl, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 48);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(878, 56);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 56);
            this.label2.TabIndex = 1;
            this.label2.Text = "typically causes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // effectFormulaControl
            // 
            this.effectFormulaControl.AutoSize = true;
            this.effectFormulaControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.effectFormulaControl.Location = new System.Drawing.Point(105, 10);
            this.effectFormulaControl.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.effectFormulaControl.MinimumSize = new System.Drawing.Size(124, 32);
            this.effectFormulaControl.Name = "effectFormulaControl";
            this.effectFormulaControl.Size = new System.Drawing.Size(124, 34);
            this.effectFormulaControl.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tableLayoutPanel3.Controls.Add(this.conditionFormulaControl, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.ifCheckBox, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 104);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(878, 58);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // conditionFormulaControl
            // 
            this.conditionFormulaControl.AutoSize = true;
            this.conditionFormulaControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.conditionFormulaControl.Enabled = false;
            this.conditionFormulaControl.Location = new System.Drawing.Point(105, 10);
            this.conditionFormulaControl.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.conditionFormulaControl.MinimumSize = new System.Drawing.Size(124, 32);
            this.conditionFormulaControl.Name = "conditionFormulaControl";
            this.conditionFormulaControl.Size = new System.Drawing.Size(124, 34);
            this.conditionFormulaControl.TabIndex = 6;
            // 
            // ifCheckBox
            // 
            this.ifCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ifCheckBox.AutoSize = true;
            this.ifCheckBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ifCheckBox.Location = new System.Drawing.Point(65, 16);
            this.ifCheckBox.Name = "ifCheckBox";
            this.ifCheckBox.Size = new System.Drawing.Size(37, 25);
            this.ifCheckBox.TabIndex = 5;
            this.ifCheckBox.Text = "if";
            this.ifCheckBox.UseVisualStyleBackColor = true;
            this.ifCheckBox.CheckedChanged += new System.EventHandler(this.ifCheckBox_CheckedChanged);
            // 
            // TypicallyCausesClauseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CausesClausePanel);
            this.Name = "TypicallyCausesClauseControl";
            this.Size = new System.Drawing.Size(878, 162);
            this.CausesClausePanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CausesClausePanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ActionComboBox;
        private System.Windows.Forms.CheckedListBox ActorsCheckedListBox;
        private System.Windows.Forms.CheckBox ExclusionCheckBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private ClauseControls.FormulaControl effectFormulaControl;
        private System.Windows.Forms.CheckBox ifCheckBox;
        private ClauseControls.FormulaControl conditionFormulaControl;
    }
}
