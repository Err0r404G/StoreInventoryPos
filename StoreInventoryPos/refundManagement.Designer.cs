namespace StoreInventoryPos
{
    partial class refundManagement
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            backButton = new Button();
            searchGrid = new DataGridView();
            refundReasonBox = new ComboBox();
            saleIDLabel = new Label();
            refundAmountLabel = new Label();
            refundReasonLabel = new Label();
            refundButton = new Button();
            clearButton = new Button();
            label1 = new Label();
            searchField = new TextBox();
            saleIDField = new TextBox();
            amountField = new TextBox();
            ((System.ComponentModel.ISupportInitialize)searchGrid).BeginInit();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.BackColor = Color.White;
            backButton.Font = new Font("Impact", 18F);
            backButton.ForeColor = Color.Crimson;
            backButton.Location = new Point(1280, 29);
            backButton.Name = "backButton";
            backButton.Size = new Size(120, 51);
            backButton.TabIndex = 16;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // searchGrid
            // 
            searchGrid.AllowUserToAddRows = false;
            searchGrid.AllowUserToDeleteRows = false;
            searchGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            searchGrid.ColumnHeadersHeight = 29;
            searchGrid.ColumnHeadersVisible = false;
            searchGrid.Location = new Point(69, 109);
            searchGrid.Name = "searchGrid";
            searchGrid.ReadOnly = true;
            searchGrid.RowHeadersVisible = false;
            searchGrid.RowHeadersWidth = 51;
            searchGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            searchGrid.Size = new Size(842, 415);
            searchGrid.TabIndex = 2;
            searchGrid.CellClick += searchGrid_CellClick_1;
            // 
            // refundReasonBox
            // 
            refundReasonBox.DropDownStyle = ComboBoxStyle.DropDownList;
            refundReasonBox.Font = new Font("Segoe UI", 13F);
            refundReasonBox.Items.AddRange(new object[] { "Damaged", "Customer Return", "Wrong Item", "Other" });
            refundReasonBox.Location = new Point(1080, 229);
            refundReasonBox.Name = "refundReasonBox";
            refundReasonBox.Size = new Size(250, 38);
            refundReasonBox.TabIndex = 12;
            // 
            // saleIDLabel
            // 
            saleIDLabel.Font = new Font("Impact", 16F);
            saleIDLabel.Location = new Point(939, 109);
            saleIDLabel.Name = "saleIDLabel";
            saleIDLabel.Size = new Size(101, 36);
            saleIDLabel.TabIndex = 5;
            saleIDLabel.Text = "Sale ID";
            // 
            // refundAmountLabel
            // 
            refundAmountLabel.Font = new Font("Impact", 16F);
            refundAmountLabel.Location = new Point(939, 171);
            refundAmountLabel.Name = "refundAmountLabel";
            refundAmountLabel.Size = new Size(101, 36);
            refundAmountLabel.TabIndex = 7;
            refundAmountLabel.Text = "Amount";
            // 
            // refundReasonLabel
            // 
            refundReasonLabel.Font = new Font("Impact", 16F);
            refundReasonLabel.Location = new Point(939, 229);
            refundReasonLabel.Name = "refundReasonLabel";
            refundReasonLabel.Size = new Size(101, 37);
            refundReasonLabel.TabIndex = 11;
            refundReasonLabel.Text = "Reason";
            // 
            // refundButton
            // 
            refundButton.BackColor = Color.FromArgb(128, 255, 128);
            refundButton.Font = new Font("Impact", 18F);
            refundButton.Location = new Point(1080, 292);
            refundButton.Name = "refundButton";
            refundButton.Size = new Size(250, 51);
            refundButton.TabIndex = 13;
            refundButton.Text = "Refund";
            refundButton.UseVisualStyleBackColor = false;
            refundButton.Click += refundButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Black;
            clearButton.Font = new Font("Impact", 18F);
            clearButton.ForeColor = Color.White;
            clearButton.Location = new Point(789, 43);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(122, 51);
            clearButton.TabIndex = 15;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click_1;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Impact", 19.8F);
            label1.Location = new Point(69, 47);
            label1.Name = "label1";
            label1.Size = new Size(127, 41);
            label1.TabIndex = 0;
            label1.Text = "Search :";
            // 
            // searchField
            // 
            searchField.BackColor = SystemColors.ControlLightLight;
            searchField.BorderStyle = BorderStyle.FixedSingle;
            searchField.Font = new Font("Segoe UI", 13.8F);
            searchField.Location = new Point(193, 47);
            searchField.Multiline = true;
            searchField.Name = "searchField";
            searchField.Size = new Size(587, 41);
            searchField.TabIndex = 37;
            searchField.TextChanged += searchField_TextChanged_1;
            // 
            // saleIDField
            // 
            saleIDField.BackColor = SystemColors.Info;
            saleIDField.BorderStyle = BorderStyle.FixedSingle;
            saleIDField.Font = new Font("Segoe UI", 13.8F);
            saleIDField.Location = new Point(1080, 104);
            saleIDField.Multiline = true;
            saleIDField.Name = "saleIDField";
            saleIDField.ReadOnly = true;
            saleIDField.Size = new Size(250, 42);
            saleIDField.TabIndex = 38;
            // 
            // amountField
            // 
            amountField.BackColor = SystemColors.ControlLightLight;
            amountField.BorderStyle = BorderStyle.FixedSingle;
            amountField.Font = new Font("Segoe UI", 13.8F);
            amountField.Location = new Point(1080, 171);
            amountField.Multiline = true;
            amountField.Name = "amountField";
            amountField.Size = new Size(250, 42);
            amountField.TabIndex = 39;
            // 
            // refundManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1450, 600);
            Controls.Add(amountField);
            Controls.Add(saleIDField);
            Controls.Add(searchField);
            Controls.Add(label1);
            Controls.Add(searchGrid);
            Controls.Add(saleIDLabel);
            Controls.Add(refundAmountLabel);
            Controls.Add(refundReasonLabel);
            Controls.Add(refundReasonBox);
            Controls.Add(refundButton);
            Controls.Add(clearButton);
            Controls.Add(backButton);
            Name = "refundManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Refund Management";
            FormClosed += refundManagement_FormClosed;
            Load += refundManagement_Load;
            ((System.ComponentModel.ISupportInitialize)searchGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1, refundIDLabel, saleIDLabel, refundAmountLabel, refundDateLabel, refundReasonLabel;
        private DateTimePicker refundDateField;
        private ComboBox refundReasonBox;
        private DataGridView searchGrid;
        private Button refundButton, deleteButton, clearButton, backButton;
        private TextBox searchField;
        private TextBox saleIDField;
        private TextBox amountField;
    }
}
