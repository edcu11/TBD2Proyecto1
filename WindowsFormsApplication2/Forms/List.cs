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
using WindowsFormsApplication2.Forms;
using static System.Windows.Forms.ListView;

namespace WindowsFormsApplication2
{
    public partial class List : MetroFramework.Forms.MetroForm
    {
        ConfigurationForm confForm;
        List<QueryResult> queryResults;
        ListConnection listConnection;

        public List(ConfigurationForm form)
        {
            confForm = form;
            queryResults = new List<QueryResult>();
            listConnection = new ListConnection(confForm.dbConnector);
            InitializeComponent();
            QRGrid.FullRowSelect = true;
        }

        private void List_Load(object sender, EventArgs e)
        {

        }

        private void BackHome_Click(object sender, EventArgs e)
        {
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

            if (ShowingLabel.Text.Equals("Tables"))
            {
                var tableShowDialog = new TableShowForm(confForm.dbConnector, id);
                tableShowDialog.ShowDialog();
            }

        }

        private void triggersTile_Click(object sender, EventArgs e)
        {
            var results = listConnection.GetDBTriggers();
            ShowingLabel.Text = "Triggers";
            ActualizarQRView(results);
        }

        #endregion


        private string GetSelectedItemID()
        {
            var indexes = QRGrid.SelectedIndices;
            var id = QRGrid.Items[indexes[0]].SubItems[1].Text;
            return RequieresSubField(id, indexes);
        }

        private string RequieresSubField(string id, SelectedIndexCollection indexes)
        {
            if (ShowingIndexes() || ShowingChecks() || ShowingProcedures())
            {
                id = id + "|" + QRGrid.Items[indexes[0]].SubItems[2].Text;
            }
            return id;
        }

        private bool ShowingChecks()
        {
            return ShowingLabel.Text.Equals("Checks");
        }

        private bool ShowingIndexes()
        {
            return ShowingLabel.Text.Equals("Indexes");
        }

        private bool ShowingTriggers()
        {
            return ShowingLabel.Text.Equals("TRIGGERS");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
        }

        private void tableCM_Opening(object sender, CancelEventArgs e)
        {
            if (QRGrid.SelectedItems.Count == 0)
            {
                e.Cancel = true;
                return;
            }

            var showingText = ShowingLabel.Text.ToList();
            showingText.RemoveAt(ShowingLabel.Text.Length - 1);

            for (int i = 0; i < tableCM.Items.Count; i++)
            {
                var predicado = tableCM.Items[i].Text.Split(' ');
                tableCM.Items[i].Text = predicado[0] + " " + new string(showingText.ToArray());
            }
        }

        private void BackHome_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void QRGrid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deleteCMI_Click(object sender, EventArgs e)
        {
            var id = GetSelectedItemID();
            DBManager deleteManager = GetDeleteType(id);

            if (deleteManager == null)
            {
                return;
            }

            var deleteForm = new DeleteObjectForm(deleteManager, confForm.dbConnector, id);
            StartForm(deleteForm);
        }

        private DBManager GetDeleteType(string id)
        {
            if (ShowingLabel.Text.Equals("Tables"))
            {
                return new TableManager();
            }

            if (ShowingTriggers())
            {
                return new TriggerManager();
            }

            if (ShowingViews())
            {
                return new ViewManager();
            }

            if (ShowingIndexes())
            {
                return new IndexManager();
            }

            if (ShowingChecks())
            {
                return new CheckManager();
            }

            if (ShowingProcedures())
            {
                if (id.Contains("Function"))
                    return new FunctionManager();
                return new ProcedureManager();
            }

            return null;
        }

        private bool ShowingProcedures()
        {
            return ShowingLabel.Text.Equals("Procedures");
        }

        private bool ShowingViews()
        {
            return ShowingLabel.Text.Equals("Views");
        }

        private void StartForm(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
            this.Activate();
        }
    }
}
