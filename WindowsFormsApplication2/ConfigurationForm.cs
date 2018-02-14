using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.Comunes;

namespace WindowsFormsApplication2
{
    public partial class ConfigurationForm : MetroFramework.Forms.MetroForm
    {
        private Home home;
        private DBConnection dbConnector;
        private ConnectionStringConfiguration connectionData;
        private ConnectionStorage cStorage;

        public ConfigurationForm(Home homep)
        {
            this.home = homep;
            connectionData = new ConnectionStringConfiguration();
            InitializeComponent();
        }


        private void ConfigurationForm_Load(object sender, EventArgs e)
        {
            cStorage = new ConnectionStorage();
            cStorage.LoadConfigurations();

            ShowStoredConfs();
        }

        private void ConfigurationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        #region Manual Binding

        private void ServerNameTxtB_TextChanged_1(object sender, EventArgs e)
        {
            connectionData.ServerName = ServerNameTxtB.Text;
        }

        private void DatabaseNameTxtB_TextChanged(object sender, EventArgs e)
        {
            connectionData.DatabaseName = DatabaseNameTxtB.Text;
        }

        private void userTxtB_TextChanged(object sender, EventArgs e)
        {
            connectionData.UserId = userTxtB.Text;
        }

        private void passwordTxtB_TextChanged(object sender, EventArgs e)
        {
            connectionData.Password = passwordTxtB.Text;
        }

        private void TrustedConnectionCB_CheckedChanged(object sender, EventArgs e)
        {
            connectionData.TrustedConnection = TrustedConnectionCB.Checked;

            if (TrustedConnectionCB.Checked)
            {
                AuthenticationLabel.Hide();
                return;
            }
            AuthenticationLabel.Show();

        }
        #endregion

        #region Configuration Strings

        private void SetConfString()
        {
            home.myConnectionString = connectionData.GetConfString();
            dbConnector = new DBConnection(home.myConnectionString);

            if (dbConnector.IsConnectionValid())
            {
                MessageBox.Show("Success! Connection Saved!");
                cStorage.AddConnection(connectionData);
                ReloadConfigurations();
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void ReloadConfigurations()
        {
            cStorage.SaveConfigurations();
            cStorage.LoadConfigurations();
            OldConfsCB.Items.Clear();
            ShowStoredConfs();
        }

        
        private void metroButton1_Click(object sender, EventArgs e)
        {
            SetConfString();
        }

        private void ShowStoredConfs()
        {
            foreach (var conn in cStorage.connections)
            {
                OldConfsCB.Items.Add(conn.ServerName + "|" + conn.DatabaseName);
            }
        }

        private void LoadDataFromConnection(ConnectionStringConfiguration selectedCon)
        {
            ServerNameTxtB.Text = selectedCon.ServerName;
            DatabaseNameTxtB.Text = selectedCon.DatabaseName;
            TrustedConnectionCB.Checked = selectedCon.TrustedConnection;

            if (TrustedConnectionCB.Checked)
            {
                userTxtB.Text = selectedCon.UserId;
                passwordTxtB.Text = selectedCon.Password;
            }
        }

        private void OldConfsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OldConfsCB.SelectedItem == null || OldConfsCB.SelectedItem.ToString().Equals(string.Empty))
            {
                return;
            }

            var data = OldConfsCB.SelectedItem.ToString().Split('|');
            var conIndex = cStorage.FindSavedConnection(new ConnectionStringConfiguration(data[0], data[1]));
            LoadDataFromConnection(cStorage.connections[conIndex]);
        }
        #endregion

    }
}
