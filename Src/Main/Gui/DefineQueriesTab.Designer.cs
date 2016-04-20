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
            this.label1 = new System.Windows.Forms.Label();
            this.defineQueriesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // defineQueriesPanel
            // 
            this.defineQueriesPanel.ColumnCount = 2;
            this.defineQueriesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.defineQueriesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.defineQueriesPanel.Controls.Add(this.label1, 0, 0);
            this.defineQueriesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defineQueriesPanel.Location = new System.Drawing.Point(0, 0);
            this.defineQueriesPanel.Name = "defineQueriesPanel";
            this.defineQueriesPanel.RowCount = 4;
            this.defineQueriesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.defineQueriesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.defineQueriesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.defineQueriesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64F));
            this.defineQueriesPanel.Size = new System.Drawing.Size(600, 400);
            this.defineQueriesPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.defineQueriesPanel.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "DEFINE QUERIES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DefineQueriesTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.defineQueriesPanel);
            this.Name = "DefineQueriesTab";
            this.Size = new System.Drawing.Size(600, 400);
            this.defineQueriesPanel.ResumeLayout(false);
            this.defineQueriesPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel defineQueriesPanel;
        private System.Windows.Forms.Label label1;
    }
}
