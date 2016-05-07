namespace KR.Main.Gui.QueriesControls
{
    partial class AccessibleQueryControl
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.accessibleFormulaControl = new KR.Main.Gui.ClauseControls.FormulaControl();
            this.ifFormulaControl = new KR.Main.Gui.ClauseControls.FormulaControl();
            this.Panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.ColumnCount = 1;
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.Panel.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.Panel.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.RowCount = 3;
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Panel.Size = new System.Drawing.Size(592, 179);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(592, 53);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 53);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(592, 62);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 62);
            this.label2.TabIndex = 3;
            this.label2.Text = "accessible";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoScroll = true;
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.ifFormulaControl, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 115);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(592, 64);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 64);
            this.label3.TabIndex = 3;
            this.label3.Text = "if";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accessibleFormulaControl
            // 
            this.accessibleFormulaControl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.accessibleFormulaControl.AutoSize = true;
            this.accessibleFormulaControl.Location = new System.Drawing.Point(124, 14);
            this.accessibleFormulaControl.Margin = new System.Windows.Forms.Padding(0);
            this.accessibleFormulaControl.MinimumSize = new System.Drawing.Size(124, 32);
            this.accessibleFormulaControl.Name = "accessibleFormulaControl";
            this.accessibleFormulaControl.Size = new System.Drawing.Size(124, 34);
            this.accessibleFormulaControl.TabIndex = 4;
            // 
            // ifFormulaControl
            // 
            this.ifFormulaControl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ifFormulaControl.AutoSize = true;
            this.ifFormulaControl.Location = new System.Drawing.Point(26, 15);
            this.ifFormulaControl.Margin = new System.Windows.Forms.Padding(0);
            this.ifFormulaControl.MinimumSize = new System.Drawing.Size(124, 32);
            this.ifFormulaControl.Name = "ifFormulaControl";
            this.ifFormulaControl.Size = new System.Drawing.Size(124, 34);
            this.ifFormulaControl.TabIndex = 4;
            // 
            // AccessibleQueryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel);
            this.Name = "AccessibleQueryControl";
            this.Size = new System.Drawing.Size(592, 179);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ClauseControls.FormulaControl accessibleFormulaControl;
        private ClauseControls.FormulaControl ifFormulaControl;
    }
}
