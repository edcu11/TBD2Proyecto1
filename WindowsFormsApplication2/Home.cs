using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {

        public string myConnectionString;
        public Home()
        {
            InitializeComponent();
            myConnectionString = String.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartForm(Form form, bool conf)
        {
            if (myConnectionString.Equals(string.Empty) && !conf)
            {
                MessageBox.Show("Establish connection first!");
                return;
            }
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void CreateTile_Click(object sender, EventArgs e)
        {
            StartForm(new Create(this), false);
        }

        private void ListTile_Click(object sender, EventArgs e)
        {
            StartForm(new List(this), false);
        }


        private void metroLink1_Click_1(object sender, EventArgs e)
        {

        }

        private void UpdateBD_Click(object sender, EventArgs e)
        {
            StartForm(new UpdateWindow(this), false);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            StartForm(new Delete(this), false);
        }

        private void ConfLink_Click(object sender, EventArgs e)
        {
            StartForm(new ConfigurationForm(this), true);
            //form.Show();
            //this.Hide();
        }
    }
}
