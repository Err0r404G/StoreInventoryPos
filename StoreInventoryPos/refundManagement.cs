using System.Data;
using WFAManagementPro;

namespace StoreInventoryPos
{
    public partial class refundManagement : Form
    {
        public refundManagement()
        {
            InitializeComponent();
            LoadSalesIntoGrid(); // Load all on form load

            searchField.TextChanged += searchField_TextChanged;
            clearButton.Click += clearButton_Click;
            refundButton.Click += refundButton_Click;
            searchGrid.CellClick += searchGrid_CellClick;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            managerDashboard Back = new managerDashboard();
            Back.Show();
        }

        private void LoadSalesIntoGrid(string saleId = "")
        {
            try
            {
                DataAccess db = new DataAccess();
                DataTable sales = db.GetSaleReport(saleId);
                searchGrid.DataSource = sales;

                if (searchGrid.Columns.Contains("SaleID"))
                    searchGrid.Columns["SaleID"].HeaderText = "Sale ID";
                if (searchGrid.Columns.Contains("CustomerName"))
                    searchGrid.Columns["CustomerName"].HeaderText = "Customer";
                if (searchGrid.Columns.Contains("TotalAmount"))
                    searchGrid.Columns["TotalAmount"].HeaderText = "Amount";
                if (searchGrid.Columns.Contains("PaymentType"))
                    searchGrid.Columns["PaymentType"].HeaderText = "Payment";
                if (searchGrid.Columns.Contains("UsedPromo"))
                    searchGrid.Columns["UsedPromo"].HeaderText = "Promo";
                if (searchGrid.Columns.Contains("Date"))
                    searchGrid.Columns["Date"].HeaderText = "Date";
                if (searchGrid.Columns.Contains("PaymentToken"))
                    searchGrid.Columns["PaymentToken"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales: " + ex.Message);
            }
        }

        private void searchField_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchField.Text.Trim();
            LoadSalesIntoGrid(searchText);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            searchField.Text = "";
            saleIDField.Text = "";
            amountField.Text = "";
            refundReasonBox.SelectedIndex = -1;
            LoadSalesIntoGrid();
        }

        private void searchGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && searchGrid.Rows.Count > 0)
            {
                DataGridViewRow row = searchGrid.Rows[e.RowIndex];
                saleIDField.Text = row.Cells["SaleID"].Value.ToString();
                amountField.Text = row.Cells["TotalAmount"].Value.ToString();
            }
        }

        private void refundButton_Click(object sender, EventArgs e)
        {
            string amountText = amountField.Text.Trim();
            string reason = refundReasonBox.Text.Trim();
            string saleId = saleIDField.Text.Trim();

            if (string.IsNullOrWhiteSpace(amountText) ||
                string.IsNullOrWhiteSpace(reason) ||
                string.IsNullOrWhiteSpace(saleId))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (!decimal.TryParse(amountText, out decimal amount))
            {
                MessageBox.Show("Invalid amount format.");
                return;
            }

            try
            {
                DataAccess db = new DataAccess();
                int refundId = db.InsertRefundAndGetId(amount, reason);

                if (refundId > 0)
                {
                    bool linkSuccess = db.LinkSaleToRefund(saleId, refundId);
                    if (linkSuccess)
                    {
                        MessageBox.Show("Refund successfully recorded and linked to sale.");
                        clearButton_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Refund saved but failed to link to Sale.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to record refund.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
