namespace KR.Main.Gui
{
    partial class InitiallyClauseControl
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
            this.InitiallyClausePanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.InitiallyClausePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InitiallyClausePanel
            // 
            this.InitiallyClausePanel.ColumnCount = 2;
            this.InitiallyClausePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.InitiallyClausePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.InitiallyClausePanel.Controls.Add(this.label1, 0, 0);
            this.InitiallyClausePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InitiallyClausePanel.Location = new System.Drawing.Point(0, 0);
            this.InitiallyClausePanel.Margin = new System.Windows.Forms.Padding(0);
            this.InitiallyClausePanel.Name = "InitiallyClausePanel";
            this.InitiallyClausePanel.RowCount = 1;
            this.InitiallyClausePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InitiallyClausePanel.Size = new System.Drawing.Size(878, 162);
            this.InitiallyClausePanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 162);
            this.label1.TabIndex = 0;
            this.label1.Text = "initially";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InitiallyClauseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InitiallyClausePanel);
            this.Name = "InitiallyClauseControl";
            this.Size = new System.Drawing.Size(878, 162);
            this.InitiallyClausePanel.ResumeLayout(false);
            this.InitiallyClausePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel InitiallyClausePanel;
        private System.Windows.Forms.Label label1;
    }
}
