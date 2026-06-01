namespace StoreInventoryPos
{
    partial class AuditLog
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
            titleLabel = new Label();
            searchLabel = new Label();
            searchField = new TextBox();
            clearButton = new Button();
            backButton = new Button();
            auditGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)auditGrid).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(32, 24);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(194, 54);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Audit Log";
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchLabel.Location = new Point(36, 101);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(149, 25);
            searchLabel.TabIndex = 1;
            searchLabel.Text = "Search by user";
            // 
            // searchField
            // 
            searchField.Location = new Point(191, 98);
            searchField.Name = "searchField";
            searchField.Size = new Size(316, 27);
            searchField.TabIndex = 2;
            searchField.TextChanged += searchField_TextChanged;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(525, 94);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(112, 38);
            clearButton.TabIndex = 3;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(1007, 24);
            backButton.Name = "backButton";
            backButton.Size = new Size(112, 42);
            backButton.TabIndex = 4;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // auditGrid
            // 
            auditGrid.AllowUserToAddRows = false;
            auditGrid.AllowUserToDeleteRows = false;
            auditGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            auditGrid.Location = new Point(32, 154);
            auditGrid.Name = "auditGrid";
            auditGrid.ReadOnly = true;
            auditGrid.RowHeadersWidth = 51;
            auditGrid.Size = new Size(1087, 494);
            auditGrid.TabIndex = 5;
            // 
            // AuditLog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 681);
            Controls.Add(auditGrid);
            Controls.Add(backButton);
            Controls.Add(clearButton);
            Controls.Add(searchField);
            Controls.Add(searchLabel);
            Controls.Add(titleLabel);
            Name = "AuditLog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Audit Log";
            FormClosed += AuditLog_FormClosed;
            ((System.ComponentModel.ISupportInitialize)auditGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label titleLabel;
        private Label searchLabel;
        private TextBox searchField;
        private Button clearButton;
        private Button backButton;
        private DataGridView auditGrid;
    }
}
