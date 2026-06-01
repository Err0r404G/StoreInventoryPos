using System.Data;
using System.Windows.Forms;
using WFAManagementPro;

namespace StoreInventoryPos
{
    public partial class AuditLog : ThemedForm
    {
        private readonly DataAccess dataAccess = new DataAccess();

        public AuditLog()
        {
            InitializeComponent();
            LoadAuditLogs();
        }

        private void LoadAuditLogs(string username = "")
        {
            try
            {
                DataTable auditLogs = dataAccess.GetAuditLogs(username);
                auditGrid.DataSource = auditLogs;

                if (auditGrid.Columns.Contains("AuditLogID"))
                    auditGrid.Columns["AuditLogID"].HeaderText = "ID";
                if (auditGrid.Columns.Contains("Username"))
                    auditGrid.Columns["Username"].HeaderText = "User";
                if (auditGrid.Columns.Contains("Role"))
                    auditGrid.Columns["Role"].HeaderText = "Role";
                if (auditGrid.Columns.Contains("Action"))
                    auditGrid.Columns["Action"].HeaderText = "Action";
                if (auditGrid.Columns.Contains("Details"))
                    auditGrid.Columns["Details"].HeaderText = "Details";
                if (auditGrid.Columns.Contains("CreatedAt"))
                    auditGrid.Columns["CreatedAt"].HeaderText = "Time";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load audit logs: " + ex.Message, "Audit Log", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchField_TextChanged(object sender, EventArgs e)
        {
            LoadAuditLogs(searchField.Text.Trim());
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            searchField.Clear();
            LoadAuditLogs();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminDashboard dashboard = new adminDashboard();
            dashboard.Show();
        }

        private void AuditLog_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

