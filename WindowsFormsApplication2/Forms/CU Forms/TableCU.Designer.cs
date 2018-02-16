namespace WindowsFormsApplication2.Forms.CU_Forms
{
    partial class TableCU
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TableNametxt = new MetroFramework.Controls.MetroTextBox();
            this.columnLV = new MetroFramework.Controls.MetroListView();
            this.ColumnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IsPrimary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AllowNull = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isForeign = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RefTable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RefColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.referenceColumn = new MetroFramework.Controls.MetroComboBox();
            this.referenceTable = new MetroFramework.Controls.MetroComboBox();
            this.isAllowNullCB = new MetroFramework.Controls.MetroCheckBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.isForeignKeyCB = new MetroFramework.Controls.MetroCheckBox();
            this.isPrimaryCB = new MetroFramework.Controls.MetroCheckBox();
            this.typeTB = new MetroFramework.Controls.MetroTextBox();
            this.columnNameTB = new MetroFramework.Controls.MetroTextBox();
            this.creatTablebtn = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Table Name";
            // 
            // TableNametxt
            // 
            // 
            // 
            // 
            this.TableNametxt.CustomButton.Image = null;
            this.TableNametxt.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.TableNametxt.CustomButton.Name = "";
            this.TableNametxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TableNametxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TableNametxt.CustomButton.TabIndex = 1;
            this.TableNametxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TableNametxt.CustomButton.UseSelectable = true;
            this.TableNametxt.CustomButton.Visible = false;
            this.TableNametxt.Lines = new string[0];
            this.TableNametxt.Location = new System.Drawing.Point(110, 72);
            this.TableNametxt.MaxLength = 32767;
            this.TableNametxt.Name = "TableNametxt";
            this.TableNametxt.PasswordChar = '\0';
            this.TableNametxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TableNametxt.SelectedText = "";
            this.TableNametxt.SelectionLength = 0;
            this.TableNametxt.SelectionStart = 0;
            this.TableNametxt.ShortcutsEnabled = true;
            this.TableNametxt.Size = new System.Drawing.Size(206, 23);
            this.TableNametxt.TabIndex = 1;
            this.TableNametxt.UseSelectable = true;
            this.TableNametxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TableNametxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TableNametxt.TextChanged += new System.EventHandler(this.TableNametxt_TextChanged);
            // 
            // columnLV
            // 
            this.columnLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnName,
            this.ColumnType,
            this.IsPrimary,
            this.AllowNull,
            this.isForeign,
            this.RefTable,
            this.RefColumn});
            this.columnLV.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.columnLV.FullRowSelect = true;
            this.columnLV.Location = new System.Drawing.Point(24, 127);
            this.columnLV.Name = "columnLV";
            this.columnLV.OwnerDraw = true;
            this.columnLV.Size = new System.Drawing.Size(655, 260);
            this.columnLV.TabIndex = 2;
            this.columnLV.UseCompatibleStateImageBehavior = false;
            this.columnLV.UseSelectable = true;
            // 
            // ColumnName
            // 
            this.ColumnName.Text = "Column Name";
            // 
            // ColumnType
            // 
            this.ColumnType.Text = "Column Type";
            // 
            // IsPrimary
            // 
            this.IsPrimary.Text = "IsPrimary";
            // 
            // AllowNull
            // 
            this.AllowNull.Text = "AllowNull";
            // 
            // isForeign
            // 
            this.isForeign.Text = "isForeign";
            // 
            // RefTable
            // 
            this.RefTable.Text = "RefTable";
            // 
            // RefColumn
            // 
            this.RefColumn.Text = "RefColumn";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.referenceColumn);
            this.metroPanel1.Controls.Add(this.referenceTable);
            this.metroPanel1.Controls.Add(this.isAllowNullCB);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.isForeignKeyCB);
            this.metroPanel1.Controls.Add(this.isPrimaryCB);
            this.metroPanel1.Controls.Add(this.typeTB);
            this.metroPanel1.Controls.Add(this.columnNameTB);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 393);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(522, 152);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // referenceColumn
            // 
            this.referenceColumn.FormattingEnabled = true;
            this.referenceColumn.ItemHeight = 23;
            this.referenceColumn.Location = new System.Drawing.Point(273, 57);
            this.referenceColumn.Name = "referenceColumn";
            this.referenceColumn.Size = new System.Drawing.Size(189, 29);
            this.referenceColumn.TabIndex = 9;
            this.referenceColumn.UseSelectable = true;
            // 
            // referenceTable
            // 
            this.referenceTable.FormattingEnabled = true;
            this.referenceTable.ItemHeight = 23;
            this.referenceTable.Location = new System.Drawing.Point(273, 21);
            this.referenceTable.Name = "referenceTable";
            this.referenceTable.Size = new System.Drawing.Size(189, 29);
            this.referenceTable.TabIndex = 8;
            this.referenceTable.UseSelectable = true;
            this.referenceTable.SelectedIndexChanged += new System.EventHandler(this.referenceTable_SelectedIndexChanged);
            // 
            // isAllowNullCB
            // 
            this.isAllowNullCB.AutoSize = true;
            this.isAllowNullCB.Location = new System.Drawing.Point(131, 51);
            this.isAllowNullCB.Name = "isAllowNullCB";
            this.isAllowNullCB.Size = new System.Drawing.Size(83, 15);
            this.isAllowNullCB.TabIndex = 7;
            this.isAllowNullCB.Text = "Allows Null";
            this.isAllowNullCB.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(296, 102);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(130, 23);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Add Column";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // isForeignKeyCB
            // 
            this.isForeignKeyCB.AutoSize = true;
            this.isForeignKeyCB.Location = new System.Drawing.Point(17, 81);
            this.isForeignKeyCB.Name = "isForeignKeyCB";
            this.isForeignKeyCB.Size = new System.Drawing.Size(85, 15);
            this.isForeignKeyCB.TabIndex = 5;
            this.isForeignKeyCB.Text = "Foreign Key";
            this.isForeignKeyCB.UseSelectable = true;
            // 
            // isPrimaryCB
            // 
            this.isPrimaryCB.AutoSize = true;
            this.isPrimaryCB.Location = new System.Drawing.Point(17, 51);
            this.isPrimaryCB.Name = "isPrimaryCB";
            this.isPrimaryCB.Size = new System.Drawing.Size(86, 15);
            this.isPrimaryCB.TabIndex = 4;
            this.isPrimaryCB.Text = "Primary Key";
            this.isPrimaryCB.UseSelectable = true;
            // 
            // typeTB
            // 
            // 
            // 
            // 
            this.typeTB.CustomButton.Image = null;
            this.typeTB.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.typeTB.CustomButton.Name = "";
            this.typeTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.typeTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.typeTB.CustomButton.TabIndex = 1;
            this.typeTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.typeTB.CustomButton.UseSelectable = true;
            this.typeTB.CustomButton.Visible = false;
            this.typeTB.Lines = new string[0];
            this.typeTB.Location = new System.Drawing.Point(131, 21);
            this.typeTB.MaxLength = 32767;
            this.typeTB.Name = "typeTB";
            this.typeTB.PasswordChar = '\0';
            this.typeTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.typeTB.SelectedText = "";
            this.typeTB.SelectionLength = 0;
            this.typeTB.SelectionStart = 0;
            this.typeTB.ShortcutsEnabled = true;
            this.typeTB.Size = new System.Drawing.Size(83, 23);
            this.typeTB.TabIndex = 3;
            this.typeTB.UseSelectable = true;
            this.typeTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.typeTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // columnNameTB
            // 
            // 
            // 
            // 
            this.columnNameTB.CustomButton.Image = null;
            this.columnNameTB.CustomButton.Location = new System.Drawing.Point(85, 1);
            this.columnNameTB.CustomButton.Name = "";
            this.columnNameTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.columnNameTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.columnNameTB.CustomButton.TabIndex = 1;
            this.columnNameTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.columnNameTB.CustomButton.UseSelectable = true;
            this.columnNameTB.CustomButton.Visible = false;
            this.columnNameTB.Lines = new string[0];
            this.columnNameTB.Location = new System.Drawing.Point(17, 22);
            this.columnNameTB.MaxLength = 32767;
            this.columnNameTB.Name = "columnNameTB";
            this.columnNameTB.PasswordChar = '\0';
            this.columnNameTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.columnNameTB.SelectedText = "";
            this.columnNameTB.SelectionLength = 0;
            this.columnNameTB.SelectionStart = 0;
            this.columnNameTB.ShortcutsEnabled = true;
            this.columnNameTB.Size = new System.Drawing.Size(107, 23);
            this.columnNameTB.TabIndex = 2;
            this.columnNameTB.UseSelectable = true;
            this.columnNameTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.columnNameTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // creatTablebtn
            // 
            this.creatTablebtn.Location = new System.Drawing.Point(470, 72);
            this.creatTablebtn.Name = "creatTablebtn";
            this.creatTablebtn.Size = new System.Drawing.Size(177, 23);
            this.creatTablebtn.TabIndex = 4;
            this.creatTablebtn.Text = "Create  Table";
            this.creatTablebtn.UseSelectable = true;
            this.creatTablebtn.Click += new System.EventHandler(this.creatTablebtn_Click);
            // 
            // TableCU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 643);
            this.Controls.Add(this.creatTablebtn);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.columnLV);
            this.Controls.Add(this.TableNametxt);
            this.Controls.Add(this.metroLabel1);
            this.Name = "TableCU";
            this.Text = "Table Management";
            this.Load += new System.EventHandler(this.TableCU_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TableNametxt;
        private MetroFramework.Controls.MetroListView columnLV;
        private System.Windows.Forms.ColumnHeader ColumnName;
        private System.Windows.Forms.ColumnHeader ColumnType;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox typeTB;
        private MetroFramework.Controls.MetroTextBox columnNameTB;
        private MetroFramework.Controls.MetroCheckBox isPrimaryCB;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroCheckBox isForeignKeyCB;
        private MetroFramework.Controls.MetroCheckBox isAllowNullCB;
        private MetroFramework.Controls.MetroComboBox referenceColumn;
        private MetroFramework.Controls.MetroComboBox referenceTable;
        private MetroFramework.Controls.MetroButton creatTablebtn;
        private System.Windows.Forms.ColumnHeader IsPrimary;
        private System.Windows.Forms.ColumnHeader AllowNull;
        private System.Windows.Forms.ColumnHeader isForeign;
        private System.Windows.Forms.ColumnHeader RefTable;
        private System.Windows.Forms.ColumnHeader RefColumn;
    }
}