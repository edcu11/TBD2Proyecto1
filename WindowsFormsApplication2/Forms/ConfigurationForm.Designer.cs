namespace WindowsFormsApplication2
{
    partial class ConfigurationForm
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
            this.DatabaseNameTxtB = new MetroFramework.Controls.MetroTextBox();
            this.TrustedConnectionCB = new MetroFramework.Controls.MetroCheckBox();
            this.passwordTxtB = new System.Windows.Forms.MaskedTextBox();
            this.userTxtB = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.OldConfsCB = new MetroFramework.Controls.MetroComboBox();
            this.ServerNameTxtB = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.serverLabel = new MetroFramework.Controls.MetroLabel();
            this.AuthenticationLabel = new MetroFramework.Controls.MetroPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.AuthenticationLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatabaseNameTxtB
            // 
            // 
            // 
            // 
            this.DatabaseNameTxtB.CustomButton.Image = null;
            this.DatabaseNameTxtB.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.DatabaseNameTxtB.CustomButton.Name = "";
            this.DatabaseNameTxtB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.DatabaseNameTxtB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DatabaseNameTxtB.CustomButton.TabIndex = 1;
            this.DatabaseNameTxtB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DatabaseNameTxtB.CustomButton.UseSelectable = true;
            this.DatabaseNameTxtB.CustomButton.Visible = false;
            this.DatabaseNameTxtB.Lines = new string[0];
            this.DatabaseNameTxtB.Location = new System.Drawing.Point(97, 41);
            this.DatabaseNameTxtB.MaxLength = 32767;
            this.DatabaseNameTxtB.Name = "DatabaseNameTxtB";
            this.DatabaseNameTxtB.PasswordChar = '\0';
            this.DatabaseNameTxtB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DatabaseNameTxtB.SelectedText = "";
            this.DatabaseNameTxtB.SelectionLength = 0;
            this.DatabaseNameTxtB.SelectionStart = 0;
            this.DatabaseNameTxtB.ShortcutsEnabled = true;
            this.DatabaseNameTxtB.Size = new System.Drawing.Size(185, 23);
            this.DatabaseNameTxtB.TabIndex = 0;
            this.DatabaseNameTxtB.UseSelectable = true;
            this.DatabaseNameTxtB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DatabaseNameTxtB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.DatabaseNameTxtB.TextChanged += new System.EventHandler(this.DatabaseNameTxtB_TextChanged);
            // 
            // TrustedConnectionCB
            // 
            this.TrustedConnectionCB.AutoSize = true;
            this.TrustedConnectionCB.Checked = true;
            this.TrustedConnectionCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TrustedConnectionCB.Location = new System.Drawing.Point(109, 70);
            this.TrustedConnectionCB.Name = "TrustedConnectionCB";
            this.TrustedConnectionCB.Size = new System.Drawing.Size(124, 15);
            this.TrustedConnectionCB.TabIndex = 4;
            this.TrustedConnectionCB.Text = "TrustedConnection";
            this.TrustedConnectionCB.UseSelectable = true;
            this.TrustedConnectionCB.CheckedChanged += new System.EventHandler(this.TrustedConnectionCB_CheckedChanged);
            // 
            // passwordTxtB
            // 
            this.passwordTxtB.Location = new System.Drawing.Point(98, 41);
            this.passwordTxtB.Name = "passwordTxtB";
            this.passwordTxtB.PasswordChar = '*';
            this.passwordTxtB.Size = new System.Drawing.Size(185, 20);
            this.passwordTxtB.TabIndex = 1;
            this.passwordTxtB.UseSystemPasswordChar = true;
            this.passwordTxtB.TextChanged += new System.EventHandler(this.passwordTxtB_TextChanged);
            // 
            // userTxtB
            // 
            // 
            // 
            // 
            this.userTxtB.CustomButton.Image = null;
            this.userTxtB.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.userTxtB.CustomButton.Name = "";
            this.userTxtB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.userTxtB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userTxtB.CustomButton.TabIndex = 1;
            this.userTxtB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userTxtB.CustomButton.UseSelectable = true;
            this.userTxtB.CustomButton.Visible = false;
            this.userTxtB.Lines = new string[0];
            this.userTxtB.Location = new System.Drawing.Point(98, 12);
            this.userTxtB.MaxLength = 32767;
            this.userTxtB.Name = "userTxtB";
            this.userTxtB.PasswordChar = '\0';
            this.userTxtB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userTxtB.SelectedText = "";
            this.userTxtB.SelectionLength = 0;
            this.userTxtB.SelectionStart = 0;
            this.userTxtB.ShortcutsEnabled = true;
            this.userTxtB.Size = new System.Drawing.Size(185, 23);
            this.userTxtB.TabIndex = 0;
            this.userTxtB.UseSelectable = true;
            this.userTxtB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userTxtB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.userTxtB.TextChanged += new System.EventHandler(this.userTxtB_TextChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(121, 327);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(105, 23);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Connect";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // OldConfsCB
            // 
            this.OldConfsCB.FormattingEnabled = true;
            this.OldConfsCB.ItemHeight = 23;
            this.OldConfsCB.Location = new System.Drawing.Point(23, 63);
            this.OldConfsCB.Name = "OldConfsCB";
            this.OldConfsCB.Size = new System.Drawing.Size(297, 29);
            this.OldConfsCB.TabIndex = 7;
            this.OldConfsCB.UseSelectable = true;
            this.OldConfsCB.SelectedIndexChanged += new System.EventHandler(this.OldConfsCB_SelectedIndexChanged);
            // 
            // ServerNameTxtB
            // 
            // 
            // 
            // 
            this.ServerNameTxtB.CustomButton.Image = null;
            this.ServerNameTxtB.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.ServerNameTxtB.CustomButton.Name = "";
            this.ServerNameTxtB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ServerNameTxtB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ServerNameTxtB.CustomButton.TabIndex = 1;
            this.ServerNameTxtB.CustomButton.Text = "\r\n";
            this.ServerNameTxtB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ServerNameTxtB.CustomButton.UseSelectable = true;
            this.ServerNameTxtB.CustomButton.Visible = false;
            this.ServerNameTxtB.Lines = new string[0];
            this.ServerNameTxtB.Location = new System.Drawing.Point(97, 12);
            this.ServerNameTxtB.MaxLength = 32767;
            this.ServerNameTxtB.Name = "ServerNameTxtB";
            this.ServerNameTxtB.PasswordChar = '\0';
            this.ServerNameTxtB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ServerNameTxtB.SelectedText = "";
            this.ServerNameTxtB.SelectionLength = 0;
            this.ServerNameTxtB.SelectionStart = 0;
            this.ServerNameTxtB.ShortcutsEnabled = true;
            this.ServerNameTxtB.Size = new System.Drawing.Size(185, 23);
            this.ServerNameTxtB.TabIndex = 0;
            this.ServerNameTxtB.UseSelectable = true;
            this.ServerNameTxtB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ServerNameTxtB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ServerNameTxtB.TextChanged += new System.EventHandler(this.ServerNameTxtB_TextChanged_1);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.serverLabel);
            this.metroPanel1.Controls.Add(this.DatabaseNameTxtB);
            this.metroPanel1.Controls.Add(this.TrustedConnectionCB);
            this.metroPanel1.Controls.Add(this.ServerNameTxtB);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(24, 120);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(296, 108);
            this.metroPanel1.TabIndex = 9;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 41);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Database ";
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Location = new System.Drawing.Point(4, 12);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(87, 19);
            this.serverLabel.TabIndex = 2;
            this.serverLabel.Text = "Server Name";
            // 
            // AuthenticationLabel
            // 
            this.AuthenticationLabel.Controls.Add(this.metroLabel3);
            this.AuthenticationLabel.Controls.Add(this.metroLabel2);
            this.AuthenticationLabel.Controls.Add(this.passwordTxtB);
            this.AuthenticationLabel.Controls.Add(this.userTxtB);
            this.AuthenticationLabel.HorizontalScrollbarBarColor = true;
            this.AuthenticationLabel.HorizontalScrollbarHighlightOnWheel = false;
            this.AuthenticationLabel.HorizontalScrollbarSize = 10;
            this.AuthenticationLabel.Location = new System.Drawing.Point(23, 234);
            this.AuthenticationLabel.Name = "AuthenticationLabel";
            this.AuthenticationLabel.Size = new System.Drawing.Size(297, 87);
            this.AuthenticationLabel.TabIndex = 10;
            this.AuthenticationLabel.VerticalScrollbarBarColor = true;
            this.AuthenticationLabel.VerticalScrollbarHighlightOnWheel = false;
            this.AuthenticationLabel.VerticalScrollbarSize = 10;
            this.AuthenticationLabel.Visible = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(5, 41);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Password";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(5, 12);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "User Id";
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 407);
            this.Controls.Add(this.AuthenticationLabel);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.OldConfsCB);
            this.Controls.Add(this.metroButton1);
            this.Name = "ConfigurationForm";
            this.Text = "ConfigurationForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfigurationForm_FormClosed);
            this.Load += new System.EventHandler(this.ConfigurationForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.AuthenticationLabel.ResumeLayout(false);
            this.AuthenticationLabel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox DatabaseNameTxtB;
        private MetroFramework.Controls.MetroCheckBox TrustedConnectionCB;
        private MetroFramework.Controls.MetroTextBox userTxtB;
        private System.Windows.Forms.MaskedTextBox passwordTxtB;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox OldConfsCB;
        private MetroFramework.Controls.MetroTextBox ServerNameTxtB;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel serverLabel;
        private MetroFramework.Controls.MetroPanel AuthenticationLabel;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}