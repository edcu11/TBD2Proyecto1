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
    public partial class ProcedureCU : MetroFramework.Forms.MetroForm
    {
        DBConnection connection;
        ListConnection listQueries;
        ProcedureManager tManager;

        public ProcedureCU(DBConnection conn)
        {
            InitializeComponent();
            connection = conn;
            listQueries = new ListConnection(conn);
            tManager = new ProcedureManager();
        }

        private void ProcedureCU_Load(object sender, EventArgs e)
        {


        }

        private void createProcedure_Click(object sender, EventArgs e)
        {
            var procedureHelper = new ProcedureData(Nametxt.Text, varsTxt.Text,
                        scriptTb.Text);
            var sql = tManager.CreateQuery(procedureHelper);

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
