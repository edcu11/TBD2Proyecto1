namespace WindowsFormsApplication2.Forms.CU_Forms
{
    partial class FunctionCU
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
            this.createFunction = new MetroFramework.Controls.MetroButton();
            this.scriptTb = new System.Windows.Forms.RichTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Nametxt = new MetroFramework.Controls.MetroTextBox();
            this.returnTypeTxt = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // createFunction
            // 
            this.createFunction.Location = new System.Drawing.Point(260, 365);
            this.createFunction.Name = "createFunction";
            this.createFunction.Size = new System.Drawing.Size(131, 23);
            this.createFunction.TabIndex = 23;
            this.createFunction.Text = "Create Function";
            this.createFunction.UseSelectable = true;
            this.createFunction.Click += new System.EventHandler(this.createFunction_Click_1);
            // 
            // scriptTb
            // 
            this.scriptTb.Location = new System.Drawing.Point(23, 137);
            this.scriptTb.Name = "scriptTb";
            this.scriptTb.Size = new System.Drawing.Size(651, 222);
            this.scriptTb.TabIndex = 22;
            this.scriptTb.Text = "";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(23, 109);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 25);
            this.metroLabel2.TabIndex = 21;
            this.metroLabel2.Text = "Script";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(260, 72);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(101, 25);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Return Type";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 25);
            this.metroLabel1.TabIndex = 19;
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
            this.Nametxt.Location = new System.Drawing.Point(87, 72);
            this.Nametxt.MaxLength = 32767;
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.PasswordChar = '\0';
            this.Nametxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Nametxt.SelectedText = "";
            this.Nametxt.SelectionLength = 0;
            this.Nametxt.SelectionStart = 0;
            this.Nametxt.ShortcutsEnabled = true;
            this.Nametxt.Size = new System.Drawing.Size(144, 23);
            this.Nametxt.TabIndex = 18;
            this.Nametxt.UseSelectable = true;
            this.Nametxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Nametxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // returnTypeTxt
            // 
            // 
            // 
            // 
            this.returnTypeTxt.CustomButton.Image = null;
            this.returnTypeTxt.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.returnTypeTxt.CustomButton.Name = "";
            this.returnTypeTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.returnTypeTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.returnTypeTxt.CustomButton.TabIndex = 1;
            this.returnTypeTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.returnTypeTxt.CustomButton.UseSelectable = true;
            this.returnTypeTxt.CustomButton.Visible = false;
            this.returnTypeTxt.Lines = new string[0];
            this.returnTypeTxt.Location = new System.Drawing.Point(367, 70);
            this.returnTypeTxt.MaxLength = 32767;
            this.returnTypeTxt.Name = "returnTypeTxt";
            this.returnTypeTxt.PasswordChar = '\0';
            this.returnTypeTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.returnTypeTxt.SelectedText = "";
            this.returnTypeTxt.SelectionLength = 0;
            this.returnTypeTxt.SelectionStart = 0;
            this.returnTypeTxt.ShortcutsEnabled = true;
            this.returnTypeTxt.Size = new System.Drawing.Size(144, 23);
            this.returnTypeTxt.TabIndex = 24;
            this.returnTypeTxt.UseSelectable = true;
            this.returnTypeTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.returnTypeTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FunctionCU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 423);
            this.Controls.Add(this.returnTypeTxt);
            this.Controls.Add(this.createFunction);
            this.Controls.Add(this.scriptTb);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Nametxt);
            this.Name = "FunctionCU";
            this.Text = "FunctionCU";
            this.Load += new System.EventHandler(this.FunctionCU_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton createFunction;
        private System.Windows.Forms.RichTextBox scriptTb;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox Nametxt;
        private MetroFramework.Controls.MetroTextBox returnTypeTxt;
    }
}