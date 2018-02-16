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
    public partial class FunctionCU : MetroFramework.Forms.MetroForm
    {
        DBConnection connection;
        ListConnection listQueries;
        FunctionManager tManager;

        public FunctionCU(DBConnection conn)
        {
            InitializeComponent();
            connection = conn;
            listQueries = new ListConnection(conn);
            tManager = new FunctionManager();
        }

        private void FunctionCU_Load(object sender, EventArgs e)
        {


        }

        private void createFunction_Click_1(object sender, EventArgs e)
        {
            var functionHelper = new FunctionData(Nametxt.Text, returnTypeTxt.Text,
                      scriptTb.Text);
            var sql = tManager.CreateQuery(functionHelper);

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
