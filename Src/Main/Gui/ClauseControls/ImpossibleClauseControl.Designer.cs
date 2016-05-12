namespace KR.Main.Gui.ClauseControls
{
    partial class ImpossibleClauseControl
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
            this.Panel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ActionComboBox = new System.Windows.Forms.ComboBox();
            this.ActorsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.ExclusionCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.conditionFormulaControl = new KR.Main.Gui.ClauseControls.FormulaControl();
            this.ifCheckBox = new System.Windows.Forms.CheckBox();
            this.Panel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.ColumnCount = 1;
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.Panel.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Panel.Name = "Panel";
            this.Panel.RowCount = 2;
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Panel.Size = new System.Drawing.Size(878, 110);
            this.Panel.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(878, 55);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(367, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 55);
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
            this.label1.Size = new System.Drawing.Size(122, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "impossible";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ActionComboBox
            // 
            this.ActionComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionComboBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ActionComboBox.FormattingEnabled = true;
            this.ActionComboBox.Location = new System.Drawing.Point(125, 7);
            this.ActionComboBox.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.ActionComboBox.Name = "ActionComboBox";
            this.ActionComboBox.Size = new System.Drawing.Size(239, 32);
            this.ActionComboBox.TabIndex = 1;
            // 
            // ActorsCheckedListBox
            // 
            this.ActorsCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActorsCheckedListBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ActorsCheckedListBox.FormattingEnabled = true;
            this.ActorsCheckedListBox.HorizontalScrollbar = true;
            this.ActorsCheckedListBox.Location = new System.Drawing.Point(580, 3);
            this.ActorsCheckedListBox.Name = "ActorsCheckedListBox";
            this.ActorsCheckedListBox.Size = new System.Drawing.Size(295, 49);
            this.ActorsCheckedListBox.TabIndex = 4;
            // 
            // ExclusionCheckBox
            // 
            this.ExclusionCheckBox.AutoSize = true;
            this.ExclusionCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExclusionCheckBox.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExclusionCheckBox.Location = new System.Drawing.Point(510, 3);
            this.ExclusionCheckBox.Name = "ExclusionCheckBox";
            this.ExclusionCheckBox.Size = new System.Drawing.Size(64, 49);
            this.ExclusionCheckBox.TabIndex = 5;
            this.ExclusionCheckBox.Text = "¬";
            this.ExclusionCheckBox.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.ifCheckBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.conditionFormulaControl, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 55);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(878, 55);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // conditionFormulaControl
            // 
            this.conditionFormulaControl.AutoSize = true;
            this.conditionFormulaControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.conditionFormulaControl.Enabled = false;
            this.conditionFormulaControl.Location = new System.Drawing.Point(43, 10);
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
            this.ifCheckBox.Location = new System.Drawing.Point(3, 15);
            this.ifCheckBox.Name = "ifCheckBox";
            this.ifCheckBox.Size = new System.Drawing.Size(37, 25);
            this.ifCheckBox.TabIndex = 8;
            this.ifCheckBox.Text = "if";
            this.ifCheckBox.UseVisualStyleBackColor = true;
            this.ifCheckBox.CheckedChanged += new System.EventHandler(this.ifCheckBox_CheckedChanged);
            // 
            // ImpossibleClauseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel);
            this.Name = "ImpossibleClauseControl";
            this.Size = new System.Drawing.Size(878, 110);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ActionComboBox;
        private System.Windows.Forms.CheckedListBox ActorsCheckedListBox;
        private System.Windows.Forms.CheckBox ExclusionCheckBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private ClauseControls.FormulaControl conditionFormulaControl;
        private System.Windows.Forms.CheckBox ifCheckBox;
    }
}
