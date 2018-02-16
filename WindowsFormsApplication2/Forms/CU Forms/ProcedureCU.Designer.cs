namespace WindowsFormsApplication2.Forms.CU_Forms
{
    partial class ProcedureCU
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
            this.scriptTb = new System.Windows.Forms.RichTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Nametxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.varsTxt = new MetroFramework.Controls.MetroTextBox();
            this.createProcedure = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // scriptTb
            // 
            this.scriptTb.Location = new System.Drawing.Point(23, 141);
            this.scriptTb.Name = "scriptTb";
            this.scriptTb.Size = new System.Drawing.Size(651, 222);
            this.scriptTb.TabIndex = 19;
            this.scriptTb.Text = "";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(23, 113);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 25);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Script";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 25);
            this.metroLabel1.TabIndex = 17;
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
            this.Nametxt.Location = new System.Drawing.Point(87, 76);
            this.Nametxt.MaxLength = 32767;
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.PasswordChar = '\0';
            this.Nametxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Nametxt.SelectedText = "";
            this.Nametxt.SelectionLength = 0;
            this.Nametxt.SelectionStart = 0;
            this.Nametxt.ShortcutsEnabled = true;
            this.Nametxt.Size = new System.Drawing.Size(144, 23);
            this.Nametxt.TabIndex = 16;
            this.Nametxt.UseSelectable = true;
            this.Nametxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Nametxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(264, 74);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(47, 25);
            this.metroLabel3.TabIndex = 21;
            this.metroLabel3.Text = "Vars:";
            // 
            // varsTxt
            // 
            // 
            // 
            // 
            this.varsTxt.CustomButton.Image = null;
            this.varsTxt.CustomButton.Location = new System.Drawing.Point(284, 1);
            this.varsTxt.CustomButton.Name = "";
            this.varsTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.varsTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.varsTxt.CustomButton.TabIndex = 1;
            this.varsTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.varsTxt.CustomButton.UseSelectable = true;
            this.varsTxt.CustomButton.Visible = false;
            this.varsTxt.Lines = new string[0];
            this.varsTxt.Location = new System.Drawing.Point(328, 76);
            this.varsTxt.MaxLength = 32767;
            this.varsTxt.Name = "varsTxt";
            this.varsTxt.PasswordChar = '\0';
            this.varsTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.varsTxt.SelectedText = "";
            this.varsTxt.SelectionLength = 0;
            this.varsTxt.SelectionStart = 0;
            this.varsTxt.ShortcutsEnabled = true;
            this.varsTxt.Size = new System.Drawing.Size(306, 23);
            this.varsTxt.TabIndex = 20;
            this.varsTxt.UseSelectable = true;
            this.varsTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.varsTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // createProcedure
            // 
            this.createProcedure.Location = new System.Drawing.Point(264, 369);
            this.createProcedure.Name = "createProcedure";
            this.createProcedure.Size = new System.Drawing.Size(131, 23);
            this.createProcedure.TabIndex = 22;
            this.createProcedure.Text = "Create Procedure";
            this.createProcedure.UseSelectable = true;
            this.createProcedure.Click += new System.EventHandler(this.createProcedure_Click);
            // 
            // ProcedureCU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 406);
            this.Controls.Add(this.createProcedure);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.varsTxt);
            this.Controls.Add(this.scriptTb);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Nametxt);
            this.Name = "ProcedureCU";
            this.Text = "ProcedureCU";
            this.Load += new System.EventHandler(this.ProcedureCU_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox scriptTb;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox Nametxt;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox varsTxt;
        private MetroFramework.Controls.MetroButton createProcedure;
    }
}