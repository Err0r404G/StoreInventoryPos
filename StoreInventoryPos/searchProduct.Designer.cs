namespace StoreInventoryPos
{
    partial class searchProduct
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
            backButton = new Button();
            searchGrid = new DataGridView();
            searchButton = new Button();
            searchField = new TextBox();
            SearchLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)searchGrid).BeginInit();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.BackColor = Color.White;
            backButton.Cursor = Cursors.Hand;
            backButton.FlatStyle = FlatStyle.Popup;
            backButton.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.Crimson;
            backButton.Location = new Point(928, 30);
            backButton.Name = "backButton";
            backButton.Size = new Size(112, 51);
            backButton.TabIndex = 39;
            backButton.Text = "BACK";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // searchGrid
            // 
            searchGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchGrid.Location = new Point(28, 98);
            searchGrid.Name = "searchGrid";
            searchGrid.RowHeadersWidth = 51;
            searchGrid.Size = new Size(879, 415);
            searchGrid.TabIndex = 38;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.Red;
            searchButton.Cursor = Cursors.Hand;
            searchButton.FlatStyle = FlatStyle.Popup;
            searchButton.Font = new Font("Impact", 19.8F);
            searchButton.ForeColor = Color.LavenderBlush;
            searchButton.Location = new Point(493, 38);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(69, 46);
            searchButton.TabIndex = 37;
            searchButton.Text = "GO";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click_1;
            // 
            // searchField
            // 
            searchField.BackColor = SystemColors.ControlLightLight;
            searchField.BorderStyle = BorderStyle.FixedSingle;
            searchField.Font = new Font("Segoe UI", 13.8F);
            searchField.Location = new Point(161, 42);
            searchField.Multiline = true;
            searchField.Name = "searchField";
            searchField.Size = new Size(326, 42);
            searchField.TabIndex = 36;
            // 
            // SearchLabel
            // 
            SearchLabel.AutoSize = true;
            SearchLabel.BackColor = SystemColors.Control;
            SearchLabel.Font = new Font("Impact", 19.8F);
            SearchLabel.Location = new Point(28, 42);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(127, 41);
            SearchLabel.TabIndex = 35;
            SearchLabel.Text = "Search :";
            // 
            // searchProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 605);
            Controls.Add(backButton);
            Controls.Add(searchGrid);
            Controls.Add(searchButton);
            Controls.Add(searchField);
            Controls.Add(SearchLabel);
            Name = "searchProduct";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Product Search";
            Load += searchProduct_Load;
            ((System.ComponentModel.ISupportInitialize)searchGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private DataGridView searchGrid;
        private Button searchButton;
        private TextBox searchField;
        private Label SearchLabel;
    }
}