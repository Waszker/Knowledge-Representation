namespace KR.Main.Gui
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.nextButtonLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.previousButtonLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.mainLayoutPanel.SuspendLayout();
            this.nextButtonLayoutPanel.SuspendLayout();
            this.previousButtonLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.ColumnCount = 3;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.mainLayoutPanel.Controls.Add(this.previousButtonLayoutPanel, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.nextButtonLayoutPanel, 2, 0);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 1;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.21127F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.78873F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(689, 426);
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // nextButtonLayoutPanel
            // 
            this.nextButtonLayoutPanel.ColumnCount = 1;
            this.nextButtonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.nextButtonLayoutPanel.Controls.Add(this.nextButton, 0, 1);
            this.nextButtonLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nextButtonLayoutPanel.Location = new System.Drawing.Point(636, 3);
            this.nextButtonLayoutPanel.Name = "nextButtonLayoutPanel";
            this.nextButtonLayoutPanel.RowCount = 3;
            this.nextButtonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.nextButtonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.nextButtonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.nextButtonLayoutPanel.Size = new System.Drawing.Size(50, 420);
            this.nextButtonLayoutPanel.TabIndex = 1;
            // 
            // previousButtonLayoutPanel
            // 
            this.previousButtonLayoutPanel.ColumnCount = 1;
            this.previousButtonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.previousButtonLayoutPanel.Controls.Add(this.previousButton, 0, 1);
            this.previousButtonLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previousButtonLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.previousButtonLayoutPanel.Name = "previousButtonLayoutPanel";
            this.previousButtonLayoutPanel.RowCount = 3;
            this.previousButtonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.previousButtonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.previousButtonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.previousButtonLayoutPanel.Size = new System.Drawing.Size(49, 420);
            this.previousButtonLayoutPanel.TabIndex = 2;
            // 
            // previousButton
            // 
            this.previousButton.BackgroundImage = global::KR.Main.Properties.Resources.arrowLeft;
            this.previousButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previousButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousButton.Location = new System.Drawing.Point(3, 192);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(43, 36);
            this.previousButton.TabIndex = 0;
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackgroundImage = global::KR.Main.Properties.Resources.arrowRight;
            this.nextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Location = new System.Drawing.Point(3, 192);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(44, 36);
            this.nextButton.TabIndex = 0;
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 426);
            this.Controls.Add(this.mainLayoutPanel);
            this.Name = "Form1";
            this.Text = "Knowledge Representation";
            this.mainLayoutPanel.ResumeLayout(false);
            this.nextButtonLayoutPanel.ResumeLayout(false);
            this.previousButtonLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel nextButtonLayoutPanel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TableLayoutPanel previousButtonLayoutPanel;
        private System.Windows.Forms.Button previousButton;
    }
}

