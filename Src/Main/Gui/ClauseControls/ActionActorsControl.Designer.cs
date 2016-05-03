namespace KR.Main.Gui.ClauseControls
{
    partial class ActionActorsControl
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
            this.ActionComboBox = new System.Windows.Forms.ComboBox();
            this.ExclusionCheckBox = new System.Windows.Forms.CheckBox();
            this.ActorsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.AutoSize = true;
            this.Panel.ColumnCount = 3;
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.Panel.Controls.Add(this.ActorsCheckedListBox, 2, 0);
            this.Panel.Controls.Add(this.ExclusionCheckBox, 1, 0);
            this.Panel.Controls.Add(this.ActionComboBox, 0, 0);
            this.Panel.Controls.Add(this.button1, 0, 1);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.RowCount = 2;
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Panel.Size = new System.Drawing.Size(667, 96);
            this.Panel.TabIndex = 0;
            // 
            // ActionComboBox
            // 
            this.ActionComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionComboBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ActionComboBox.FormattingEnabled = true;
            this.ActionComboBox.Location = new System.Drawing.Point(3, 7);
            this.ActionComboBox.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.ActionComboBox.Name = "ActionComboBox";
            this.ActionComboBox.Size = new System.Drawing.Size(294, 32);
            this.ActionComboBox.TabIndex = 2;
            // 
            // ExclusionCheckBox
            // 
            this.ExclusionCheckBox.AutoSize = true;
            this.ExclusionCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExclusionCheckBox.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExclusionCheckBox.Location = new System.Drawing.Point(303, 3);
            this.ExclusionCheckBox.Name = "ExclusionCheckBox";
            this.ExclusionCheckBox.Size = new System.Drawing.Size(60, 42);
            this.ExclusionCheckBox.TabIndex = 6;
            this.ExclusionCheckBox.Text = "¬";
            this.ExclusionCheckBox.UseVisualStyleBackColor = true;
            // 
            // ActorsCheckedListBox
            // 
            this.ActorsCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActorsCheckedListBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ActorsCheckedListBox.FormattingEnabled = true;
            this.ActorsCheckedListBox.HorizontalScrollbar = true;
            this.ActorsCheckedListBox.Location = new System.Drawing.Point(369, 3);
            this.ActorsCheckedListBox.Name = "ActorsCheckedListBox";
            this.ActorsCheckedListBox.Size = new System.Drawing.Size(295, 42);
            this.ActorsCheckedListBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(3, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ActionActorsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.Panel);
            this.Name = "ActionActorsControl";
            this.Size = new System.Drawing.Size(667, 96);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Panel;
        private System.Windows.Forms.ComboBox ActionComboBox;
        private System.Windows.Forms.CheckBox ExclusionCheckBox;
        private System.Windows.Forms.CheckedListBox ActorsCheckedListBox;
        private System.Windows.Forms.Button button1;
    }
}
