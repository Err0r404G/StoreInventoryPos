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
    public partial class saleReport : Form
    {
        public saleReport()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {

            if (Users.Role == "ADMIN")
            {
                this.Hide();
                adminDashboard Back = new adminDashboard();
                Back.Show();
            }
            if (Users.Role == "MANAGER")
            {
                this.Hide();
                managerDashboard Back = new managerDashboard();
                Back.Show();
            }
            if (Users.Role == "STAFF")
            {
                this.Hide();
                staffDashboard Back = new staffDashboard();
                Back.Show();
            }
        }
    }
}
