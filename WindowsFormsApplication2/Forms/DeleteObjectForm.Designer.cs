namespace WindowsFormsApplication2.Forms
{
    partial class DeleteObjectForm
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
            this.ExpositoryText = new MetroFramework.Controls.MetroLabel();
            this.objectIdLabel = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.CancelTile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // ExpositoryText
            // 
            this.ExpositoryText.AutoSize = true;
            this.ExpositoryText.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ExpositoryText.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.ExpositoryText.Location = new System.Drawing.Point(122, 79);
            this.ExpositoryText.Name = "ExpositoryText";
            this.ExpositoryText.Size = new System.Drawing.Size(386, 25);
            this.ExpositoryText.TabIndex = 0;
            this.ExpositoryText.Text = "Are you sure you want to delete this object?";
            // 
            // objectIdLabel
            // 
            this.objectIdLabel.AutoSize = true;
            this.objectIdLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.objectIdLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.objectIdLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.objectIdLabel.Location = new System.Drawing.Point(235, 104);
            this.objectIdLabel.Name = "objectIdLabel";
            this.objectIdLabel.Size = new System.Drawing.Size(0, 0);
            this.objectIdLabel.TabIndex = 1;
            this.objectIdLabel.UseCustomForeColor = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(122, 150);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(179, 80);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Delete";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // CancelTile
            // 
            this.CancelTile.ActiveControl = null;
            this.CancelTile.Location = new System.Drawing.Point(326, 150);
            this.CancelTile.Name = "CancelTile";
            this.CancelTile.Size = new System.Drawing.Size(182, 80);
            this.CancelTile.Style = MetroFramework.MetroColorStyle.Red;
            this.CancelTile.TabIndex = 3;
            this.CancelTile.Text = "Cancel";
            this.CancelTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CancelTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.CancelTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.CancelTile.UseSelectable = true;
            this.CancelTile.Click += new System.EventHandler(this.CancelTile_Click);
            // 
            // DeleteObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 253);
            this.Controls.Add(this.CancelTile);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.objectIdLabel);
            this.Controls.Add(this.ExpositoryText);
            this.Name = "DeleteObjectForm";
            this.Text = "Delete";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.DeleteObjectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel ExpositoryText;
        private MetroFramework.Controls.MetroLabel objectIdLabel;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile CancelTile;
    }
}