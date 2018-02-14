namespace WindowsFormsApplication2
{
    partial class Delete
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
            this.BackHome = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // BackHome
            // 
            this.BackHome.Image = global::WindowsFormsApplication2.Properties.Resources.Navigation_Right1;
            this.BackHome.ImageSize = 42;
            this.BackHome.Location = new System.Drawing.Point(502, 47);
            this.BackHome.Name = "BackHome";
            this.BackHome.Size = new System.Drawing.Size(31, 26);
            this.BackHome.TabIndex = 2;
            this.BackHome.UseCustomBackColor = true;
            this.BackHome.UseCustomForeColor = true;
            this.BackHome.UseSelectable = true;
            this.BackHome.UseStyleColors = true;
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 557);
            this.Controls.Add(this.BackHome);
            this.Name = "Delete";
            this.RightToLeftLayout = true;
            this.Text = "DeleteWindow";
            this.Load += new System.EventHandler(this.DeleteWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink BackHome;
    }
}