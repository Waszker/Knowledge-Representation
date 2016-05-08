namespace KR.Main.Gui.QueriesControls
{
    partial class AccessibleWhenQueryControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TypicallyRadioButton = new System.Windows.Forms.RadioButton();
            this.EverRadioButton = new System.Windows.Forms.RadioButton();
            this.AlwaysRadioButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.ScenarioTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.accessibleFormulaControl = new KR.Main.Gui.ClauseControls.FormulaControl();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.ifFormulaControl = new KR.Main.Gui.ClauseControls.FormulaControl();
            this.ifCheckBox = new System.Windows.Forms.CheckBox();
            this.Panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.ColumnCount = 1;
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.Panel.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.Panel.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.Panel.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.RowCount = 4;
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.Panel.Size = new System.Drawing.Size(592, 239);
            this.Panel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.TypicallyRadioButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.EverRadioButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AlwaysRadioButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(592, 47);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TypicallyRadioButton
            // 
            this.TypicallyRadioButton.AutoSize = true;
            this.TypicallyRadioButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TypicallyRadioButton.Location = new System.Drawing.Point(397, 3);
            this.TypicallyRadioButton.Name = "TypicallyRadioButton";
            this.TypicallyRadioButton.Size = new System.Drawing.Size(112, 28);
            this.TypicallyRadioButton.TabIndex = 3;
            this.TypicallyRadioButton.TabStop = true;
            this.TypicallyRadioButton.Text = "typically";
            this.TypicallyRadioButton.UseVisualStyleBackColor = true;
            // 
            // EverRadioButton
            // 
            this.EverRadioButton.AutoSize = true;
            this.EverRadioButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EverRadioButton.Location = new System.Drawing.Point(200, 3);
            this.EverRadioButton.Name = "EverRadioButton";
            this.EverRadioButton.Size = new System.Drawing.Size(75, 28);
            this.EverRadioButton.TabIndex = 2;
            this.EverRadioButton.TabStop = true;
            this.EverRadioButton.Text = "ever";
            this.EverRadioButton.UseVisualStyleBackColor = true;
            // 
            // AlwaysRadioButton
            // 
            this.AlwaysRadioButton.AutoSize = true;
            this.AlwaysRadioButton.Checked = true;
            this.AlwaysRadioButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AlwaysRadioButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AlwaysRadioButton.Location = new System.Drawing.Point(3, 3);
            this.AlwaysRadioButton.Name = "AlwaysRadioButton";
            this.AlwaysRadioButton.Size = new System.Drawing.Size(98, 28);
            this.AlwaysRadioButton.TabIndex = 1;
            this.AlwaysRadioButton.TabStop = true;
            this.AlwaysRadioButton.Text = "always";
            this.AlwaysRadioButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ScenarioTextBox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 165);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(592, 74);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 74);
            this.label1.TabIndex = 2;
            this.label1.Text = "when";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScenarioTextBox
            // 
            this.ScenarioTextBox.BackColor = System.Drawing.Color.White;
            this.ScenarioTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScenarioTextBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ScenarioTextBox.Location = new System.Drawing.Point(91, 3);
            this.ScenarioTextBox.Multiline = true;
            this.ScenarioTextBox.Name = "ScenarioTextBox";
            this.ScenarioTextBox.ReadOnly = true;
            this.ScenarioTextBox.Size = new System.Drawing.Size(498, 68);
            this.ScenarioTextBox.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.accessibleFormulaControl, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 47);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(592, 59);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 59);
            this.label2.TabIndex = 3;
            this.label2.Text = "accessible";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accessibleFormulaControl
            // 
            this.accessibleFormulaControl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.accessibleFormulaControl.AutoSize = true;
            this.accessibleFormulaControl.Location = new System.Drawing.Point(124, 12);
            this.accessibleFormulaControl.Margin = new System.Windows.Forms.Padding(0);
            this.accessibleFormulaControl.MinimumSize = new System.Drawing.Size(124, 32);
            this.accessibleFormulaControl.Name = "accessibleFormulaControl";
            this.accessibleFormulaControl.Size = new System.Drawing.Size(124, 34);
            this.accessibleFormulaControl.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoScroll = true;
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.ifCheckBox, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.ifFormulaControl, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 106);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(592, 59);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // ifFormulaControl
            // 
            this.ifFormulaControl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ifFormulaControl.AutoSize = true;
            this.ifFormulaControl.Location = new System.Drawing.Point(43, 12);
            this.ifFormulaControl.Margin = new System.Windows.Forms.Padding(0);
            this.ifFormulaControl.MinimumSize = new System.Drawing.Size(124, 32);
            this.ifFormulaControl.Name = "ifFormulaControl";
            this.ifFormulaControl.Size = new System.Drawing.Size(124, 34);
            this.ifFormulaControl.TabIndex = 4;
            // 
            // ifCheckBox
            // 
            this.ifCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ifCheckBox.AutoSize = true;
            this.ifCheckBox.Checked = true;
            this.ifCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ifCheckBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ifCheckBox.Location = new System.Drawing.Point(3, 17);
            this.ifCheckBox.Name = "ifCheckBox";
            this.ifCheckBox.Size = new System.Drawing.Size(37, 25);
            this.ifCheckBox.TabIndex = 7;
            this.ifCheckBox.Text = "if";
            this.ifCheckBox.UseVisualStyleBackColor = true;
            this.ifCheckBox.CheckedChanged += new System.EventHandler(this.ifCheckBox_CheckedChanged);
            // 
            // AccessibleWhenQueryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel);
            this.Name = "AccessibleWhenQueryControl";
            this.Size = new System.Drawing.Size(592, 239);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton AlwaysRadioButton;
        private System.Windows.Forms.RadioButton TypicallyRadioButton;
        private System.Windows.Forms.RadioButton EverRadioButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ScenarioTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label2;
        private ClauseControls.FormulaControl accessibleFormulaControl;
        private ClauseControls.FormulaControl ifFormulaControl;
        private System.Windows.Forms.CheckBox ifCheckBox;
    }
}
