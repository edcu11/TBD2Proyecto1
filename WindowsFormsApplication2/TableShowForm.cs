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

namespace WindowsFormsApplication2
{
    public partial class TableShowForm : MetroFramework.Forms.MetroForm
    {
        DBConnection connection;
        public string  tableName { get; set; }
        public SqlDataAdapter Adapter;
        public DataTable Table;

        public TableShowForm(string connectionString, string tableN)
        {
            InitializeComponent();
            connection = new DBConnection(connectionString);
            tableName = tableN;
        }

        private void TableShowForm_Load(object sender, EventArgs e)
        {
            Adapter = connection.ExecuteCommandReader(GetTableSQL());
            var commandBuilder = new SqlCommandBuilder(Adapter);
            Table = new DataTable();
            Adapter.Fill(Table);
            TableShowGrid.DataSource = Table;
        }

        private string GetTableSQL()
        {
            return "SELECT * FROM " + tableName;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Adapter.Update(Table);
                Table.AcceptChanges();
            }
            catch (DBConcurrencyException error)
            {
                MessageBox.Show(error.Message);
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
           
        }
    }
}
