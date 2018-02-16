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
    public partial class TriggerCU : MetroFramework.Forms.MetroForm
    {
        DBConnection connection;
        ListConnection listQueries;
        TriggerManager tManager;
        QueryResult tables;

        public TriggerCU(DBConnection conn)
        {
            InitializeComponent();
            connection = conn;
            listQueries = new ListConnection(conn);
            tManager = new TriggerManager();
        }

        private void TriggerCU_Load(object sender, EventArgs e)
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

        private void createTrigger_Click(object sender, EventArgs e)
        {
            var triggerHelper = new TriggerData(triggerNametxt.Text, referenceTable.SelectedItem.ToString(),
                                   whenCB.SelectedItem.ToString(), scriptTb.Text);
            triggerHelper.DefineActionTrigger(InsertCb.Checked, DeleteCb.Checked, UpdateCb.Checked);
            var sql = tManager.CreateQuery(triggerHelper);

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
