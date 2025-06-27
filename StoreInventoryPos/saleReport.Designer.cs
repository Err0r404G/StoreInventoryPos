namespace StoreInventoryPos
{
    partial class saleReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            searchField = new TextBox();
            searchLabel = new Label();
            clearButton = new Button();
            backButton = new Button();
            searchGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)searchGrid).BeginInit();
            SuspendLayout();
            // 
            // searchField
            // 
            searchField.BackColor = SystemColors.ControlLightLight;
            searchField.BorderStyle = BorderStyle.FixedSingle;
            searchField.Font = new Font("Segoe UI", 13.8F);
            searchField.Location = new Point(170, 25);
            searchField.Multiline = true;
            searchField.Name = "searchField";
            searchField.Size = new Size(439, 41);
            searchField.TabIndex = 44;
            searchField.TextChanged += searchField_TextChanged;
            // 
            // searchLabel
            // 
            searchLabel.BackColor = SystemColors.ActiveCaption;
            searchLabel.Font = new Font("Impact", 19.8F);
            searchLabel.Location = new Point(50, 25);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(127, 41);
            searchLabel.TabIndex = 43;
            searchLabel.Text = "Search :";
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Black;
            clearButton.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearButton.ForeColor = Color.White;
            clearButton.Location = new Point(616, 25);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(89, 41);
            clearButton.TabIndex = 42;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click_1;
            // 
            // backButton
            // 
            backButton.BackColor = Color.White;
            backButton.Font = new Font("Impact", 18F);
            backButton.ForeColor = Color.Crimson;
            backButton.Location = new Point(1130, 25);
            backButton.Name = "backButton";
            backButton.Size = new Size(120, 51);
            backButton.TabIndex = 41;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // searchGrid
            // 
            searchGrid.AllowUserToAddRows = false;
            searchGrid.AllowUserToDeleteRows = false;
            searchGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            searchGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchGrid.Location = new Point(50, 85);
            searchGrid.Name = "searchGrid";
            searchGrid.ReadOnly = true;
            searchGrid.RowHeadersVisible = false;
            searchGrid.RowHeadersWidth = 51;
            searchGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            searchGrid.Size = new Size(1200, 400);
            searchGrid.TabIndex = 38;
            // 
            // saleReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 580);
            Controls.Add(searchField);
            Controls.Add(searchLabel);
            Controls.Add(clearButton);
            Controls.Add(backButton);
            Controls.Add(searchGrid);
            Name = "saleReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sales Report";
            FormClosed += saleReport_FormClosed;
            ((System.ComponentModel.ISupportInitialize)searchGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchField;
        private Label searchLabel;
        private Button clearButton;
        private Button backButton;
        private DataGridView searchGrid;
    }
}