namespace KR.Main.Gui.ClauseControls
{
    partial class FormulaControl
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
            this.formulaElementComboBox = new System.Windows.Forms.ComboBox();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.AutoSize = true;
            this.Panel.ColumnCount = 3;
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Panel.Controls.Add(this.formulaElementComboBox, 1, 0);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Panel.Name = "Panel";
            this.Panel.RowCount = 1;
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panel.Size = new System.Drawing.Size(125, 40);
            this.Panel.TabIndex = 0;
            // 
            // formulaElementComboBox
            // 
            this.formulaElementComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.formulaElementComboBox.FormattingEnabled = true;
            this.formulaElementComboBox.Items.AddRange(new object[] {
            "^",
            "v",
            "->",
            "<->",
            "¬"});
            this.formulaElementComboBox.Location = new System.Drawing.Point(3, 3);
            this.formulaElementComboBox.Name = "formulaElementComboBox";
            this.formulaElementComboBox.Size = new System.Drawing.Size(115, 27);
            this.formulaElementComboBox.TabIndex = 0;
            // 
            // FormulaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.Panel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(124, 32);
            this.Name = "FormulaControl";
            this.Size = new System.Drawing.Size(125, 40);
            this.Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Panel;
        private System.Windows.Forms.ComboBox formulaElementComboBox;
    }
}
