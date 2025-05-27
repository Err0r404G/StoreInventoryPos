using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreInventoryPos
{
    public partial class refundReport : Form
    {
        public refundReport()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            managerDashboard Back = new managerDashboard();
            Back.Show();
        }
    }
}
