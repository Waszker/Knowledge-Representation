namespace KR.Main.Gui.ClauseControls
{
    partial class ExecutableQueryControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AlwaysRadioButton = new System.Windows.Forms.RadioButton();
            this.EverRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ScenarioTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ScenarioTextBox, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(557, 94);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.AlwaysRadioButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.EverRadioButton, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(139, 94);
            this.tableLayoutPanel2.TabIndex = 0;
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
            this.AlwaysRadioButton.TabIndex = 0;
            this.AlwaysRadioButton.TabStop = true;
            this.AlwaysRadioButton.Text = "always";
            this.AlwaysRadioButton.UseVisualStyleBackColor = true;
            // 
            // EverRadioButton
            // 
            this.EverRadioButton.AutoSize = true;
            this.EverRadioButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EverRadioButton.Location = new System.Drawing.Point(3, 50);
            this.EverRadioButton.Name = "EverRadioButton";
            this.EverRadioButton.Size = new System.Drawing.Size(75, 28);
            this.EverRadioButton.TabIndex = 1;
            this.EverRadioButton.TabStop = true;
            this.EverRadioButton.Text = "ever";
            this.EverRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(142, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 94);
            this.label1.TabIndex = 1;
            this.label1.Text = "executable";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScenarioTextBox
            // 
            this.ScenarioTextBox.BackColor = System.Drawing.Color.White;
            this.ScenarioTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScenarioTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ScenarioTextBox.Location = new System.Drawing.Point(281, 3);
            this.ScenarioTextBox.Multiline = true;
            this.ScenarioTextBox.Name = "ScenarioTextBox";
            this.ScenarioTextBox.ReadOnly = true;
            this.ScenarioTextBox.Size = new System.Drawing.Size(273, 88);
            this.ScenarioTextBox.TabIndex = 2;
            // 
            // ExecutableQueryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ExecutableQueryControl";
            this.Size = new System.Drawing.Size(557, 94);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton AlwaysRadioButton;
        private System.Windows.Forms.RadioButton EverRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ScenarioTextBox;
    }
}
