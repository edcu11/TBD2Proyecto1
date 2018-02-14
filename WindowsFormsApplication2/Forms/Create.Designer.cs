namespace WindowsFormsApplication2
{
    partial class Create
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.BackHome = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(40, 93);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(142, 125);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            // 
            // BackHome
            // 
            this.BackHome.Image = global::WindowsFormsApplication2.Properties.Resources.Navigation_Right1;
            this.BackHome.ImageSize = 42;
            this.BackHome.Location = new System.Drawing.Point(730, 23);
            this.BackHome.Name = "BackHome";
            this.BackHome.Size = new System.Drawing.Size(31, 26);
            this.BackHome.TabIndex = 1;
            this.BackHome.UseCustomBackColor = true;
            this.BackHome.UseCustomForeColor = true;
            this.BackHome.UseSelectable = true;
            this.BackHome.UseStyleColors = true;
            this.BackHome.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 555);
            this.Controls.Add(this.BackHome);
            this.Controls.Add(this.metroTile1);
            this.Name = "Create";
            this.Padding = new System.Windows.Forms.Padding(49, 60, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Create";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Create_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLink BackHome;
    }
}