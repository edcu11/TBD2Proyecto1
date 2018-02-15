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

namespace WindowsFormsApplication2.Forms
{
    public partial class DeleteObjectForm : MetroFramework.Forms.MetroForm
    {
        DBManager manager;
        DBConnection connection;
        string objectId;
        public DeleteObjectForm(DBManager man, DBConnection conn, string id)
        {
            InitializeComponent();
            manager = man;
            objectId = id;
            connection = conn;
        }

        private void DeleteObjectForm_Load(object sender, EventArgs e)
        {
            objectIdLabel.Text = manager.TypeId + ": " + objectId;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            var query = manager.DeleteQuery(objectId);

            try
            {
                connection.ExecuteCommand(query , new string[] { });
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
                return;
            }

            MessageBox.Show("Object deleted succesfully!");
            this.Dispose();
        }

        private void CancelTile_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
