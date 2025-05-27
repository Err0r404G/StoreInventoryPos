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
    public partial class refundManagement : Form
    {
        public refundManagement()
        {
            InitializeComponent();
        }


        private void backButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            managerDashboard Back = new managerDashboard();
            Back.Show();
        }
    }
}
