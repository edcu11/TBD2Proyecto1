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
    public partial class List : MetroFramework.Forms.MetroForm
    {
        Home homeForm;
        List<QueryResult> queryResults;
        ListConnection listConnection;

        public List(Home home)
        {
            this.homeForm = home;
            queryResults = new List<QueryResult>();
            listConnection = new ListConnection(homeForm.myConnectionString);
            InitializeComponent();
            QRGrid.FullRowSelect = true;
        }

        private void List_Load(object sender, EventArgs e)
        {

        }

        private void BackHome_Click(object sender, EventArgs e)
        {
            homeForm.Show();
            this.Dispose();
        }


      

        private void ActualizarQRView(QueryResult tables)
        {
            QRGrid.Clear();
            QRGrid.View = View.Details;
            AddColumnsToView(tables.Fields);
            AddResultsRows(tables);
            UpdateColumnsWidth();
            QRGrid.Update();
        }


        #region Updating Table

        private void UpdateColumnsWidth()
        {
            for (int i = 0; i < QRGrid.Columns.Count; i++)
            {
                QRGrid.Columns[i].Width = -2;
            }

        }

        private void AddResultsRows(QueryResult tables)
        {
            foreach (var row in tables.Rows)
            {
                QRGrid.Items.Add(new ListViewItem(row.ToArray()));
            }
        }

        private void AddColumnsToView(List<string> columns)
        {
            foreach (var column in columns)
            {
                QRGrid.Columns.Add(column);
            }
        }

        private void AddRowsToView(List<string> rows)
        {
            foreach (var row in rows)
            {
                QRGrid.Items.Add(new ListViewItem(row));
            }
            
        }

        #endregion

        #region Listing

        private void metroTile4_Click(object sender, EventArgs e)
        {
            var results = listConnection.GetDBIndexes();
            ShowingLabel.Text = "Indexes";
            ActualizarQRView(results);
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

            var results = listConnection.GetDBTables();
            ShowingLabel.Text = "Tables";
            ActualizarQRView(results);

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            var results = listConnection.GetDBProcedures();
            ShowingLabel.Text = "Procedures";
            ActualizarQRView(results);
        }

    

        private void metroTile7_Click(object sender, EventArgs e)
        {
            var results = listConnection.GetDBChecks();
            ShowingLabel.Text = "Checks";
            ActualizarQRView(results);

        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            var results = listConnection.GetDBViews();
            ShowingLabel.Text = "Views";
            ActualizarQRView(results);
        }

        private void QRGrid_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //ActualizarQRView(new QueryResult());
        }

        private void QRGrid_DoubleClick(object sender, EventArgs e)
        {
            var id = GetSelectedItemID();

            var tableShowDialog = new TableShowForm(homeForm.myConnectionString, id);
            tableShowDialog.ShowDialog();
        }

        #endregion


        private string GetSelectedItemID()
        {
            var indexes = QRGrid.SelectedIndices;
            return QRGrid.Items[indexes[0]].SubItems[1].Text;
        }

        private void triggersTile_Click(object sender, EventArgs e)
        {
            var results = listConnection.GetDBIndexes();
            ShowingLabel.Text = "Triggers";
            ActualizarQRView(results);
        }
    }
}
