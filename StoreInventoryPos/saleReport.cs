using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

using WFAManagementPro;

namespace StoreInventoryPos
{
    public partial class saleReport : Form
    {
        public saleReport()
        {
            InitializeComponent();
            LoadSaleIntoGrid();
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
        private void LoadSaleIntoGrid(string saleId = "")

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
                    searchGrid.Columns["TotalAmount"].HeaderText = "Total";

                if (searchGrid.Columns.Contains("PaymentType"))
                    searchGrid.Columns["PaymentType"].HeaderText = "Payment";

                if (searchGrid.Columns.Contains("UsedPromo"))
                    searchGrid.Columns["UsedPromo"].HeaderText = "Promo";

                if (searchGrid.Columns.Contains("Date"))
                    searchGrid.Columns["Date"].HeaderText = "Sale Date";

                if (searchGrid.Columns.Contains("TotalProfit"))
                    searchGrid.Columns["TotalProfit"].HeaderText = "Profit";

                if (searchGrid.Columns.Contains("Quantity"))
                    searchGrid.Columns["Quantity"].HeaderText = "Quantity";

                if (searchGrid.Columns.Contains("PaymentToken"))
                    searchGrid.Columns["PaymentToken"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Data: " + ex.Message);
            }
        }

        private void searchField_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchField.Text.Trim();
            LoadSaleIntoGrid(searchText);
        }



        private void clearButton_Click_1(object sender, EventArgs e)
        {
            searchField.Text = "";
            LoadSaleIntoGrid();
        }

        private void saleReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //Exit App
        }

private void btnExport_Click(object sender, EventArgs e)
{
    try
    {
        if (searchGrid.Rows.Count == 0)
        {
            MessageBox.Show("No data to export.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        SaveFileDialog sfd = new SaveFileDialog
        {
            Filter = "PDF files (*.pdf)|*.pdf",
            FileName = "SaleReport.pdf"
        };

        if (sfd.ShowDialog() == DialogResult.OK)
        {
            // Only count visible columns
            var visibleColumns = searchGrid.Columns
                .Cast<DataGridViewColumn>()
                .Where(c => c.Visible)
                .ToList();

            Document doc = new Document(PageSize.A4.Rotate(), 10f, 10f, 20f, 10f); // Landscape
            PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
            doc.Open();

            Paragraph title = new Paragraph("Sale Report", FontFactory.GetFont("Arial", 16));
            title.Alignment = Element.ALIGN_CENTER;
            title.SpacingAfter = 20f;
            doc.Add(title);

            PdfPTable pdfTable = new PdfPTable(visibleColumns.Count);
            pdfTable.WidthPercentage = 100;
            pdfTable.HeaderRows = 1;

            // Add headers
            foreach (var column in visibleColumns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText))
                {
                    BackgroundColor = new BaseColor(230, 230, 250), // light color
                    Padding = 5,
                    HorizontalAlignment = Element.ALIGN_CENTER
                };
                pdfTable.AddCell(cell);
            }

            // Add data
            foreach (DataGridViewRow row in searchGrid.Rows)
            {
                foreach (var column in visibleColumns)
                {
                    var cellValue = row.Cells[column.Index].Value?.ToString() ?? "";
                    PdfPCell cell = new PdfPCell(new Phrase(cellValue))
                    {
                        Padding = 4,
                        HorizontalAlignment = Element.ALIGN_CENTER
                    };
                    pdfTable.AddCell(cell);
                }
            }

            doc.Add(pdfTable);
            doc.Close();

            MessageBox.Show("PDF exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error exporting PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

    }
}
