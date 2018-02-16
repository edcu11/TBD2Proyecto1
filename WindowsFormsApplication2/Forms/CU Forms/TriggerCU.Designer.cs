namespace WindowsFormsApplication2.Forms.CU_Forms
{
    partial class TriggerCU
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
            this.whenCB = new MetroFramework.Controls.MetroComboBox();
            this.InsertCb = new MetroFramework.Controls.MetroCheckBox();
            this.DeleteCb = new MetroFramework.Controls.MetroCheckBox();
            this.UpdateCb = new MetroFramework.Controls.MetroCheckBox();
            this.triggerNametxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.scriptTb = new System.Windows.Forms.RichTextBox();
            this.createTrigger = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // referenceTable
            // 
            this.referenceTable.FormattingEnabled = true;
            this.referenceTable.ItemHeight = 23;
            this.referenceTable.Location = new System.Drawing.Point(433, 94);
            this.referenceTable.Name = "referenceTable";
            this.referenceTable.Size = new System.Drawing.Size(179, 29);
            this.referenceTable.TabIndex = 0;
            this.referenceTable.UseSelectable = true;
            // 
            // whenCB
            // 
            this.whenCB.FormattingEnabled = true;
            this.whenCB.ItemHeight = 23;
            this.whenCB.Items.AddRange(new object[] {
            "For",
            "After",
            "Instead of"});
            this.whenCB.Location = new System.Drawing.Point(433, 129);
            this.whenCB.Name = "whenCB";
            this.whenCB.Size = new System.Drawing.Size(179, 29);
            this.whenCB.TabIndex = 1;
            this.whenCB.UseSelectable = true;
            // 
            // InsertCb
            // 
            this.InsertCb.AutoSize = true;
            this.InsertCb.Location = new System.Drawing.Point(618, 97);
            this.InsertCb.Name = "InsertCb";
            this.InsertCb.Size = new System.Drawing.Size(52, 15);
            this.InsertCb.TabIndex = 2;
            this.InsertCb.Text = "Insert";
            this.InsertCb.UseSelectable = true;
            // 
            // DeleteCb
            // 
            this.DeleteCb.AutoSize = true;
            this.DeleteCb.Location = new System.Drawing.Point(618, 118);
            this.DeleteCb.Name = "DeleteCb";
            this.DeleteCb.Size = new System.Drawing.Size(56, 15);
            this.DeleteCb.TabIndex = 3;
            this.DeleteCb.Text = "Delete";
            this.DeleteCb.UseSelectable = true;
            // 
            // UpdateCb
            // 
            this.UpdateCb.AutoSize = true;
            this.UpdateCb.Location = new System.Drawing.Point(618, 139);
            this.UpdateCb.Name = "UpdateCb";
            this.UpdateCb.Size = new System.Drawing.Size(61, 15);
            this.UpdateCb.TabIndex = 4;
            this.UpdateCb.Text = "Update";
            this.UpdateCb.UseSelectable = true;
            // 
            // triggerNametxt
            // 
            // 
            // 
            // 
            this.triggerNametxt.CustomButton.Image = null;
            this.triggerNametxt.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.triggerNametxt.CustomButton.Name = "";
            this.triggerNametxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.triggerNametxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.triggerNametxt.CustomButton.TabIndex = 1;
            this.triggerNametxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.triggerNametxt.CustomButton.UseSelectable = true;
            this.triggerNametxt.CustomButton.Visible = false;
            this.triggerNametxt.Lines = new string[0];
            this.triggerNametxt.Location = new System.Drawing.Point(78, 110);
            this.triggerNametxt.MaxLength = 32767;
            this.triggerNametxt.Name = "triggerNametxt";
            this.triggerNametxt.PasswordChar = '\0';
            this.triggerNametxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.triggerNametxt.SelectedText = "";
            this.triggerNametxt.SelectionLength = 0;
            this.triggerNametxt.SelectionStart = 0;
            this.triggerNametxt.ShortcutsEnabled = true;
            this.triggerNametxt.Size = new System.Drawing.Size(144, 23);
            this.triggerNametxt.TabIndex = 5;
            this.triggerNametxt.UseSelectable = true;
            this.triggerNametxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.triggerNametxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(14, 108);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 25);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Name:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(344, 97);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 25);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "On Table:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(344, 129);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 25);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "When: ";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(14, 139);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(54, 25);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Script";
            // 
            // scriptTb
            // 
            this.scriptTb.Location = new System.Drawing.Point(14, 167);
            this.scriptTb.Name = "scriptTb";
            this.scriptTb.Size = new System.Drawing.Size(651, 222);
            this.scriptTb.TabIndex = 11;
            this.scriptTb.Text = "";
            // 
            // createTrigger
            // 
            this.createTrigger.Location = new System.Drawing.Point(232, 412);
            this.createTrigger.Name = "createTrigger";
            this.createTrigger.Size = new System.Drawing.Size(131, 23);
            this.createTrigger.TabIndex = 12;
            this.createTrigger.Text = "Create Trigger";
            this.createTrigger.UseSelectable = true;
            this.createTrigger.Click += new System.EventHandler(this.createTrigger_Click);
            // 
            // TriggerCU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 510);
            this.Controls.Add(this.createTrigger);
            this.Controls.Add(this.scriptTb);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.triggerNametxt);
            this.Controls.Add(this.UpdateCb);
            this.Controls.Add(this.DeleteCb);
            this.Controls.Add(this.InsertCb);
            this.Controls.Add(this.whenCB);
            this.Controls.Add(this.referenceTable);
            this.Name = "TriggerCU";
            this.Text = "TriggerCU";
            this.Load += new System.EventHandler(this.TriggerCU_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox referenceTable;
        private MetroFramework.Controls.MetroComboBox whenCB;
        private MetroFramework.Controls.MetroCheckBox InsertCb;
        private MetroFramework.Controls.MetroCheckBox DeleteCb;
        private MetroFramework.Controls.MetroCheckBox UpdateCb;
        private MetroFramework.Controls.MetroTextBox triggerNametxt;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.RichTextBox scriptTb;
        private MetroFramework.Controls.MetroButton createTrigger;
    }
}