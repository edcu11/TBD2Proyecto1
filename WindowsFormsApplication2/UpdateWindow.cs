using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class UpdateWindow : MetroFramework.Forms.MetroForm
    {
        Home home;
        public UpdateWindow(Home home)
        {
            this.home = home;
            InitializeComponent();
        }

        private void UpdateWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
