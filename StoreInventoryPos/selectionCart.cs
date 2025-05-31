using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAManagementPro;

namespace StoreInventoryPos
{
    public partial class selectionCart : Form
    {
        public selectionCart()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            staffDashboard Open = new staffDashboard();
            Open.Show();
        }
    }
}
