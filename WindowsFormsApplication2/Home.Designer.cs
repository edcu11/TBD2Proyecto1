namespace WindowsFormsApplication2
{
    partial class Home
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.ConfLink = new MetroFramework.Controls.MetroLink();
            this.Delete = new MetroFramework.Controls.MetroTile();
            this.UpdateBD = new MetroFramework.Controls.MetroTile();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.ListTile = new MetroFramework.Controls.MetroTile();
            this.CreateTile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // ConfLink
            // 
            this.ConfLink.Image = global::WindowsFormsApplication2.Properties.Resources.Settings___091;
            this.ConfLink.ImageSize = 48;
            this.ConfLink.Location = new System.Drawing.Point(325, 11);
            this.ConfLink.Name = "ConfLink";
            this.ConfLink.Size = new System.Drawing.Size(58, 46);
            this.ConfLink.TabIndex = 7;
            this.ConfLink.UseSelectable = true;
            this.ConfLink.Click += new System.EventHandler(this.ConfLink_Click);
            // 
            // Delete
            // 
            this.Delete.ActiveControl = null;
            this.Delete.ForeColor = System.Drawing.Color.ForestGreen;
            this.Delete.Location = new System.Drawing.Point(212, 227);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(159, 124);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Delete";
            this.Delete.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Delete.TileImage = global::WindowsFormsApplication2.Properties.Resources.Delet;
            this.Delete.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete.UseSelectable = true;
            this.Delete.UseTileImage = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // UpdateBD
            // 
            this.UpdateBD.ActiveControl = null;
            this.UpdateBD.ForeColor = System.Drawing.Color.ForestGreen;
            this.UpdateBD.Location = new System.Drawing.Point(23, 227);
            this.UpdateBD.Name = "UpdateBD";
            this.UpdateBD.Size = new System.Drawing.Size(159, 124);
            this.UpdateBD.Style = MetroFramework.MetroColorStyle.Orange;
            this.UpdateBD.TabIndex = 5;
            this.UpdateBD.Text = "Update";
            this.UpdateBD.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UpdateBD.TileImage = global::WindowsFormsApplication2.Properties.Resources.Update;
            this.UpdateBD.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateBD.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.UpdateBD.UseSelectable = true;
            this.UpdateBD.UseTileImage = true;
            this.UpdateBD.Click += new System.EventHandler(this.UpdateBD_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.Image = global::WindowsFormsApplication2.Properties.Resources.Ripple1;
            this.metroLink1.ImageSize = 54;
            this.metroLink1.Location = new System.Drawing.Point(120, 16);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(41, 41);
            this.metroLink1.TabIndex = 4;
            this.metroLink1.UseCustomBackColor = true;
            this.metroLink1.UseCustomForeColor = true;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click_1);
            // 
            // ListTile
            // 
            this.ListTile.ActiveControl = null;
            this.ListTile.ForeColor = System.Drawing.Color.Crimson;
            this.ListTile.Location = new System.Drawing.Point(23, 63);
            this.ListTile.Name = "ListTile";
            this.ListTile.Size = new System.Drawing.Size(159, 124);
            this.ListTile.Style = MetroFramework.MetroColorStyle.Purple;
            this.ListTile.TabIndex = 3;
            this.ListTile.Text = "List";
            this.ListTile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ListTile.TileImage = global::WindowsFormsApplication2.Properties.Resources.List;
            this.ListTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ListTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.ListTile.UseSelectable = true;
            this.ListTile.UseTileImage = true;
            this.ListTile.Click += new System.EventHandler(this.ListTile_Click);
            // 
            // CreateTile
            // 
            this.CreateTile.ActiveControl = null;
            this.CreateTile.ForeColor = System.Drawing.Color.Crimson;
            this.CreateTile.Location = new System.Drawing.Point(212, 63);
            this.CreateTile.Name = "CreateTile";
            this.CreateTile.Size = new System.Drawing.Size(159, 124);
            this.CreateTile.Style = MetroFramework.MetroColorStyle.Green;
            this.CreateTile.TabIndex = 3;
            this.CreateTile.Text = "Create";
            this.CreateTile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CreateTile.TileImage = global::WindowsFormsApplication2.Properties.Resources.Add_New;
            this.CreateTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreateTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.CreateTile.UseSelectable = true;
            this.CreateTile.UseTileImage = true;
            this.CreateTile.Click += new System.EventHandler(this.CreateTile_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(406, 412);
            this.Controls.Add(this.ConfLink);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.UpdateBD);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.ListTile);
            this.Controls.Add(this.CreateTile);
            this.ForeColor = System.Drawing.Color.SeaGreen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Welcome";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile CreateTile;
        private MetroFramework.Controls.MetroTile ListTile;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroTile UpdateBD;
        private MetroFramework.Controls.MetroTile Delete;
        private MetroFramework.Controls.MetroLink ConfLink;
    }
}

