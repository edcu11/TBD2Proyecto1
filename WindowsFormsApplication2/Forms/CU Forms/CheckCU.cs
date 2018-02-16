using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.Comunes;

namespace WindowsFormsApplication2.Forms.CU_Forms
{
    public partial class CheckCU : MetroFramework.Forms.MetroForm
    {
        DBConnection connection;
        ListConnection listQueries;
        CheckManager tManager;
        QueryResult tables;

        public CheckCU(DBConnection conn)
        {
            InitializeComponent();
            connection = conn;
            listQueries = new ListConnection(conn);
            tManager = new CheckManager();
        }

        private void CheckCU_Load(object sender, EventArgs e)
        {
            LoadTables();
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

        private void createCheck_Click(object sender, EventArgs e)
        {
            var checkHelper = new CheckData(Nametxt.Text, referenceTable.SelectedItem.ToString(),
                                    scriptTb.Text);
            var sql = tManager.CreateQuery(checkHelper);

            try
            {
                connection.ExecuteCommand(sql, new string[] { });
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
                return;
            }

            MessageBox.Show("Query Executed Correctly!");


        }
    }
}
