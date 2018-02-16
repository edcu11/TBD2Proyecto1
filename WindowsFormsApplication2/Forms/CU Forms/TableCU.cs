using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.Comunes;

namespace WindowsFormsApplication2.Forms.CU_Forms
{
    public partial class TableCU : MetroFramework.Forms.MetroForm
    {
        ListConnection listQueries;
        QueryResult tables;
        TableManager tManager;
        DBConnection connection;

        public TableCU(DBConnection conn)
        {
            InitializeComponent();
            listQueries = new ListConnection(conn);
            tManager = new TableManager();
            connection = conn;
        }

        private void TableCU_Load(object sender, EventArgs e)
        {
            columnLV.View = View.Details;
            UpdateColumnsWidth(columnLV);
            LoadTables();
        }


        private void UpdateColumnsWidth(MetroListView ListView)
        {
            for (int i = 0; i < ListView.Columns.Count; i++)
            {
                ListView.Columns[i].Width = -2;
            }

        }

        public void LoadTables()
        {
            tables = listQueries.GetDBTables();
            AddTableNames(tables);
        }

        private void AddTableNames(QueryResult tables)
        {
            foreach (var table in tables.Rows)
            {
                referenceTable.Items.Add(table.ElementAt(1));
            }
        }

        private void referenceTable_SelectedIndexChanged(object sender, EventArgs e)
        {

            referenceColumn.Items.Clear();
            var columns = listQueries.GetTableColumn(referenceTable.SelectedItem.ToString());
            AddColumnNames(columns);
        }

        private void AddColumnNames(QueryResult tables)
        {
            foreach (var column in tables.Rows)
            {
                referenceColumn.Items.Add(column.ElementAt(1));
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ColumnData data = new ColumnData(columnNameTB.Text, typeTB.Text, isAllowNullCB.Checked.ToString(),
                                            isPrimaryCB.Checked.ToString(), isForeignKeyCB.Checked.ToString());
            if (isForeignKeyCB.Checked)
            {
                data.foreignTable = referenceTable.SelectedItem.ToString();
                data.foreignColumn = referenceColumn.SelectedItem.ToString();
            }

            tManager.AddColum(data);
            columnLV.Items.Add(new ListViewItem(data.ToStringArrya()));
        }

        private void creatTablebtn_Click(object sender, EventArgs e)
        {
            var createQuery = tManager.CreateQuery(TableNametxt.Text);
            try
            {
                connection.ExecuteCommand(createQuery, new string[] { });
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
                return;
            }

            MessageBox.Show("Query Executed Correctly!");
        }

        private void TableNametxt_TextChanged(object sender, EventArgs e)
        {
            tManager.tableName = TableNametxt.Text;
        }
    }
}
