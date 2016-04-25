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
            this.actorComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.actionComboBox = new System.Windows.Forms.ComboBox();
            this.addStep = new System.Windows.Forms.Button();
            this.scenarioStepsListBox = new System.Windows.Forms.ListBox();
            this.deleteStep = new System.Windows.Forms.Button();
            this.defineScenarioPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // defineScenarioPanel
            // 
            this.defineScenarioPanel.ColumnCount = 2;
            this.defineScenarioPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.defineScenarioPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.defineScenarioPanel.Controls.Add(this.deleteStep, 0, 9);
            this.defineScenarioPanel.Controls.Add(this.label1, 0, 0);
            this.defineScenarioPanel.Controls.Add(this.actorComboBox, 0, 5);
            this.defineScenarioPanel.Controls.Add(this.label3, 0, 4);
            this.defineScenarioPanel.Controls.Add(this.label2, 0, 2);
            this.defineScenarioPanel.Controls.Add(this.actionComboBox, 0, 3);
            this.defineScenarioPanel.Controls.Add(this.addStep, 0, 7);
            this.defineScenarioPanel.Controls.Add(this.scenarioStepsListBox, 1, 2);
            this.defineScenarioPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defineScenarioPanel.Location = new System.Drawing.Point(0, 0);
            this.defineScenarioPanel.Name = "defineScenarioPanel";
            this.defineScenarioPanel.RowCount = 11;
            this.defineScenarioPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.defineScenarioPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.defineScenarioPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.defineScenarioPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.defineScenarioPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.defineScenarioPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.defineScenarioPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.defineScenarioPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.defineScenarioPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.defineScenarioPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.defineScenarioPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.defineScenarioPanel.Size = new System.Drawing.Size(884, 561);
            this.defineScenarioPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.defineScenarioPanel.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(878, 62);
            this.label1.TabIndex = 9;
            this.label1.Text = "DEFINE SCENARIO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // actorComboBox
            // 
            this.actorComboBox.BackColor = System.Drawing.Color.White;
            this.actorComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actorComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actorComboBox.FormattingEnabled = true;
            this.actorComboBox.Location = new System.Drawing.Point(30, 247);
            this.actorComboBox.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.actorComboBox.Name = "actorComboBox";
            this.actorComboBox.Size = new System.Drawing.Size(382, 30);
            this.actorComboBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(436, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Actor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Action";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // actionComboBox
            // 
            this.actionComboBox.BackColor = System.Drawing.Color.White;
            this.actionComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actionComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actionComboBox.FormattingEnabled = true;
            this.actionComboBox.Location = new System.Drawing.Point(30, 136);
            this.actionComboBox.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.actionComboBox.Name = "actionComboBox";
            this.actionComboBox.Size = new System.Drawing.Size(382, 30);
            this.actionComboBox.TabIndex = 5;
            // 
            // addStep
            // 
            this.addStep.BackColor = System.Drawing.Color.RoyalBlue;
            this.addStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addStep.FlatAppearance.BorderSize = 0;
            this.addStep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.addStep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.addStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStep.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addStep.ForeColor = System.Drawing.Color.White;
            this.addStep.Location = new System.Drawing.Point(30, 336);
            this.addStep.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.addStep.Name = "addStep";
            this.addStep.Size = new System.Drawing.Size(382, 50);
            this.addStep.TabIndex = 7;
            this.addStep.Text = "ADD STEP";
            this.addStep.UseVisualStyleBackColor = false;
            this.addStep.Click += new System.EventHandler(this.addStep_Click);
            // 
            // scenarioStepsListBox
            // 
            this.scenarioStepsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scenarioStepsListBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scenarioStepsListBox.FormattingEnabled = true;
            this.scenarioStepsListBox.ItemHeight = 24;
            this.scenarioStepsListBox.Location = new System.Drawing.Point(445, 92);
            this.scenarioStepsListBox.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.scenarioStepsListBox.Name = "scenarioStepsListBox";
            this.defineScenarioPanel.SetRowSpan(this.scenarioStepsListBox, 8);
            this.scenarioStepsListBox.Size = new System.Drawing.Size(409, 434);
            this.scenarioStepsListBox.TabIndex = 8;
            // 
            // deleteStep
            // 
            this.deleteStep.BackColor = System.Drawing.Color.DarkGray;
            this.deleteStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteStep.FlatAppearance.BorderSize = 0;
            this.deleteStep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.deleteStep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.deleteStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteStep.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteStep.ForeColor = System.Drawing.Color.White;
            this.deleteStep.Location = new System.Drawing.Point(30, 476);
            this.deleteStep.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.deleteStep.Name = "deleteStep";
            this.deleteStep.Size = new System.Drawing.Size(382, 50);
            this.deleteStep.TabIndex = 10;
            this.deleteStep.Text = "DELETE STEP";
            this.deleteStep.UseVisualStyleBackColor = false;
            this.deleteStep.Click += new System.EventHandler(this.deleteStep_Click);
            // 
            // DefineScenarioTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.defineScenarioPanel);
            this.Name = "DefineScenarioTab";
            this.Size = new System.Drawing.Size(884, 561);
            this.defineScenarioPanel.ResumeLayout(false);
            this.defineScenarioPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel defineScenarioPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox actionComboBox;
        private System.Windows.Forms.ComboBox actorComboBox;
        private System.Windows.Forms.Button addStep;
        private System.Windows.Forms.ListBox scenarioStepsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteStep;
    }
}
