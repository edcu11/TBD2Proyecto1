namespace WindowsFormsApplication2
{
    partial class List
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
            this.ShowTables = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.QRGrid = new MetroFramework.Controls.MetroListView();
            this.BackHome = new MetroFramework.Controls.MetroLink();
            this.ShowingLabel = new MetroFramework.Controls.MetroLabel();
            this.triggersTile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // ShowTables
            // 
            this.ShowTables.ActiveControl = null;
            this.ShowTables.Location = new System.Drawing.Point(23, 108);
            this.ShowTables.Name = "ShowTables";
            this.ShowTables.Size = new System.Drawing.Size(175, 40);
            this.ShowTables.TabIndex = 3;
            this.ShowTables.Text = "Tables";
            this.ShowTables.UseCustomBackColor = true;
            this.ShowTables.UseSelectable = true;
            this.ShowTables.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(23, 200);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(175, 40);
            this.metroTile3.TabIndex = 5;
            this.metroTile3.Text = "Procedures & Fns";
            this.metroTile3.UseCustomBackColor = true;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(23, 154);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(175, 40);
            this.metroTile4.TabIndex = 6;
            this.metroTile4.Text = "Indexes";
            this.metroTile4.UseCustomBackColor = true;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Location = new System.Drawing.Point(23, 338);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(175, 40);
            this.metroTile5.TabIndex = 7;
            this.metroTile5.Text = "Views";
            this.metroTile5.UseCustomBackColor = true;
            this.metroTile5.UseSelectable = true;
            this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // metroTile7
            // 
            this.metroTile7.ActiveControl = null;
            this.metroTile7.Location = new System.Drawing.Point(23, 292);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(175, 40);
            this.metroTile7.TabIndex = 9;
            this.metroTile7.Text = "Checks";
            this.metroTile7.UseCustomBackColor = true;
            this.metroTile7.UseSelectable = true;
            this.metroTile7.Click += new System.EventHandler(this.metroTile7_Click);
            // 
            // QRGrid
            // 
            this.QRGrid.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.QRGrid.AllowColumnReorder = true;
            this.QRGrid.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.QRGrid.FullRowSelect = true;
            this.QRGrid.GridLines = true;
            this.QRGrid.Location = new System.Drawing.Point(262, 108);
            this.QRGrid.Name = "QRGrid";
            this.QRGrid.OwnerDraw = true;
            this.QRGrid.Size = new System.Drawing.Size(469, 270);
            this.QRGrid.TabIndex = 10;
            this.QRGrid.UseCompatibleStateImageBehavior = false;
            this.QRGrid.UseCustomBackColor = true;
            this.QRGrid.UseSelectable = true;
            this.QRGrid.UseStyleColors = true;
            this.QRGrid.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.QRGrid_ItemSelectionChanged);
            this.QRGrid.DoubleClick += new System.EventHandler(this.QRGrid_DoubleClick);
            // 
            // BackHome
            // 
            this.BackHome.Image = global::WindowsFormsApplication2.Properties.Resources.Navigation_Right1;
            this.BackHome.ImageSize = 42;
            this.BackHome.Location = new System.Drawing.Point(700, 16);
            this.BackHome.Name = "BackHome";
            this.BackHome.Size = new System.Drawing.Size(31, 35);
            this.BackHome.TabIndex = 2;
            this.BackHome.UseCustomBackColor = true;
            this.BackHome.UseCustomForeColor = true;
            this.BackHome.UseSelectable = true;
            this.BackHome.UseStyleColors = true;
            this.BackHome.Click += new System.EventHandler(this.BackHome_Click);
            // 
            // ShowingLabel
            // 
            this.ShowingLabel.AutoSize = true;
            this.ShowingLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ShowingLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ShowingLabel.Location = new System.Drawing.Point(262, 83);
            this.ShowingLabel.Name = "ShowingLabel";
            this.ShowingLabel.Size = new System.Drawing.Size(0, 0);
            this.ShowingLabel.Style = MetroFramework.MetroColorStyle.White;
            this.ShowingLabel.TabIndex = 11;
            this.ShowingLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ShowingLabel.UseCustomBackColor = true;
            this.ShowingLabel.UseCustomForeColor = true;
            // 
            // triggersTile
            // 
            this.triggersTile.ActiveControl = null;
            this.triggersTile.Location = new System.Drawing.Point(23, 246);
            this.triggersTile.Name = "triggersTile";
            this.triggersTile.Size = new System.Drawing.Size(175, 40);
            this.triggersTile.TabIndex = 12;
            this.triggersTile.Text = "Triggers";
            this.triggersTile.UseCustomBackColor = true;
            this.triggersTile.UseSelectable = true;
            this.triggersTile.Click += new System.EventHandler(this.triggersTile_Click);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 500);
            this.Controls.Add(this.triggersTile);
            this.Controls.Add(this.ShowingLabel);
            this.Controls.Add(this.QRGrid);
            this.Controls.Add(this.metroTile7);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.ShowTables);
            this.Controls.Add(this.BackHome);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.KeyPreview = true;
            this.Name = "List";
            this.Text = "List";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.List_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink BackHome;
        private MetroFramework.Controls.MetroTile ShowTables;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile7;
        private MetroFramework.Controls.MetroListView QRGrid;
        private MetroFramework.Controls.MetroLabel ShowingLabel;
        private MetroFramework.Controls.MetroTile triggersTile;
    }
}