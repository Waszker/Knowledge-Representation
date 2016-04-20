namespace KR.Main.Gui
{
    partial class DefineScenarioTab
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
            this.defineScenarioPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.actionComboBox = new System.Windows.Forms.ComboBox();
            this.actorComboBox = new System.Windows.Forms.ComboBox();
            this.addToScenario = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.defineScenarioPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // defineScenarioPanel
            // 
            this.defineScenarioPanel.ColumnCount = 2;
            this.defineScenarioPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.defineScenarioPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.defineScenarioPanel.Controls.Add(this.actorComboBox, 0, 5);
            this.defineScenarioPanel.Controls.Add(this.label3, 0, 4);
            this.defineScenarioPanel.Controls.Add(this.label2, 0, 2);
            this.defineScenarioPanel.Controls.Add(this.label1, 0, 0);
            this.defineScenarioPanel.Controls.Add(this.actionComboBox, 0, 3);
            this.defineScenarioPanel.Controls.Add(this.addToScenario, 0, 7);
            this.defineScenarioPanel.Controls.Add(this.listBox1, 1, 2);
            this.defineScenarioPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defineScenarioPanel.Location = new System.Drawing.Point(0, 0);
            this.defineScenarioPanel.Name = "defineScenarioPanel";
            this.defineScenarioPanel.RowCount = 8;
            this.defineScenarioPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.defineScenarioPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.defineScenarioPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.defineScenarioPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.defineScenarioPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.defineScenarioPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.defineScenarioPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.defineScenarioPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.defineScenarioPanel.Size = new System.Drawing.Size(600, 400);
            this.defineScenarioPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.defineScenarioPanel.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "DEFINE SCENARIO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "Action";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 43);
            this.label3.TabIndex = 4;
            this.label3.Text = "Actor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // actionComboBox
            // 
            this.actionComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actionComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actionComboBox.FormattingEnabled = true;
            this.actionComboBox.Location = new System.Drawing.Point(3, 115);
            this.actionComboBox.Name = "actionComboBox";
            this.actionComboBox.Size = new System.Drawing.Size(294, 30);
            this.actionComboBox.TabIndex = 5;
            // 
            // actorComboBox
            // 
            this.actorComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actorComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actorComboBox.FormattingEnabled = true;
            this.actorComboBox.Location = new System.Drawing.Point(3, 211);
            this.actorComboBox.Name = "actorComboBox";
            this.actorComboBox.Size = new System.Drawing.Size(294, 30);
            this.actorComboBox.TabIndex = 6;
            // 
            // addToScenario
            // 
            this.addToScenario.Dock = System.Windows.Forms.DockStyle.Top;
            this.addToScenario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToScenario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addToScenario.Location = new System.Drawing.Point(3, 283);
            this.addToScenario.Name = "addToScenario";
            this.addToScenario.Size = new System.Drawing.Size(294, 40);
            this.addToScenario.TabIndex = 7;
            this.addToScenario.Text = "ADD";
            this.addToScenario.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(303, 67);
            this.listBox1.Name = "listBox1";
            this.defineScenarioPanel.SetRowSpan(this.listBox1, 6);
            this.listBox1.Size = new System.Drawing.Size(294, 330);
            this.listBox1.TabIndex = 8;
            // 
            // DefineScenarioTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.defineScenarioPanel);
            this.Name = "DefineScenarioTab";
            this.Size = new System.Drawing.Size(600, 400);
            this.defineScenarioPanel.ResumeLayout(false);
            this.defineScenarioPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel defineScenarioPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox actionComboBox;
        private System.Windows.Forms.ComboBox actorComboBox;
        private System.Windows.Forms.Button addToScenario;
        private System.Windows.Forms.ListBox listBox1;
    }
}
