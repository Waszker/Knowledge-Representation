namespace KR.Main.Gui.ClauseControls
{
    partial class AlwaysClauseControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.initialFormulaControl = new KR.Main.Gui.ClauseControls.FormulaControl();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.AutoScroll = true;
            this.Panel.AutoSize = true;
            this.Panel.ColumnCount = 2;
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Panel.Controls.Add(this.label1, 0, 0);
            this.Panel.Controls.Add(this.initialFormulaControl, 1, 0);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Panel.Name = "Panel";
            this.Panel.RowCount = 1;
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel.Size = new System.Drawing.Size(878, 162);
            this.Panel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 162);
            this.label1.TabIndex = 0;
            this.label1.Text = "always";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // initialFormulaControl
            // 
            this.initialFormulaControl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.initialFormulaControl.AutoSize = true;
            this.initialFormulaControl.Location = new System.Drawing.Point(79, 64);
            this.initialFormulaControl.Margin = new System.Windows.Forms.Padding(0);
            this.initialFormulaControl.MinimumSize = new System.Drawing.Size(124, 32);
            this.initialFormulaControl.Name = "initialFormulaControl";
            this.initialFormulaControl.Size = new System.Drawing.Size(124, 34);
            this.initialFormulaControl.TabIndex = 1;
            // 
            // AlwaysClauseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel);
            this.Name = "AlwaysClauseControl";
            this.Size = new System.Drawing.Size(878, 162);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Panel;
        private System.Windows.Forms.Label label1;
        private ClauseControls.FormulaControl initialFormulaControl;
    }
}
