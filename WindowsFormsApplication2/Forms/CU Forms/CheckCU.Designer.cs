namespace WindowsFormsApplication2.Forms.CU_Forms
{
    partial class CheckCU
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
            this.referenceTable = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Nametxt = new MetroFramework.Controls.MetroTextBox();
            this.createCheck = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.scriptTb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // referenceTable
            // 
            this.referenceTable.FormattingEnabled = true;
            this.referenceTable.ItemHeight = 23;
            this.referenceTable.Location = new System.Drawing.Point(356, 86);
            this.referenceTable.Name = "referenceTable";
            this.referenceTable.Size = new System.Drawing.Size(189, 29);
            this.referenceTable.TabIndex = 0;
            this.referenceTable.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(260, 90);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(79, 25);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "On Table";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 25);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Name:";
            // 
            // Nametxt
            // 
            // 
            // 
            // 
            this.Nametxt.CustomButton.Image = null;
            this.Nametxt.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.Nametxt.CustomButton.Name = "";
            this.Nametxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Nametxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Nametxt.CustomButton.TabIndex = 1;
            this.Nametxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Nametxt.CustomButton.UseSelectable = true;
            this.Nametxt.CustomButton.Visible = false;
            this.Nametxt.Lines = new string[0];
            this.Nametxt.Location = new System.Drawing.Point(87, 90);
            this.Nametxt.MaxLength = 32767;
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.PasswordChar = '\0';
            this.Nametxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Nametxt.SelectedText = "";
            this.Nametxt.SelectionLength = 0;
            this.Nametxt.SelectionStart = 0;
            this.Nametxt.ShortcutsEnabled = true;
            this.Nametxt.Size = new System.Drawing.Size(144, 23);
            this.Nametxt.TabIndex = 10;
            this.Nametxt.UseSelectable = true;
            this.Nametxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Nametxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // createCheck
            // 
            this.createCheck.Location = new System.Drawing.Point(260, 383);
            this.createCheck.Name = "createCheck";
            this.createCheck.Size = new System.Drawing.Size(131, 23);
            this.createCheck.TabIndex = 16;
            this.createCheck.Text = "Create Check";
            this.createCheck.UseSelectable = true;
            this.createCheck.Click += new System.EventHandler(this.createCheck_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(23, 127);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 25);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Condition";
            // 
            // scriptTb
            // 
            this.scriptTb.Location = new System.Drawing.Point(23, 155);
            this.scriptTb.Name = "scriptTb";
            this.scriptTb.Size = new System.Drawing.Size(651, 222);
            this.scriptTb.TabIndex = 15;
            this.scriptTb.Text = "";
            // 
            // CheckCU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 442);
            this.Controls.Add(this.createCheck);
            this.Controls.Add(this.scriptTb);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.referenceTable);
            this.Name = "CheckCU";
            this.Text = "CheckCU";
            this.Load += new System.EventHandler(this.CheckCU_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox referenceTable;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox Nametxt;
        private MetroFramework.Controls.MetroButton createCheck;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.RichTextBox scriptTb;
    }
}