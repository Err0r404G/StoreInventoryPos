namespace StoreInventoryPos
{
    partial class mViewUser
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
            backButton.Location = new Point(578, 26);
            backButton.Margin = new Padding(3, 2, 3, 2);
            backButton.Name = "backButton";
            backButton.Size = new Size(98, 38);
            backButton.TabIndex = 38;
            backButton.Text = "BACK";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click_1;
            // 
            // searchGrid
            // 
            searchGrid.AllowUserToAddRows = false;
            searchGrid.AllowUserToDeleteRows = false;
            searchGrid.AllowUserToResizeRows = false;
            searchGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            searchGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchGrid.ColumnHeadersVisible = false;
            searchGrid.Location = new Point(24, 74);
            searchGrid.Margin = new Padding(3, 2, 3, 2);
            searchGrid.Name = "searchGrid";
            searchGrid.ReadOnly = true;
            searchGrid.RowHeadersVisible = false;
            searchGrid.RowHeadersWidth = 51;
            searchGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            searchGrid.Size = new Size(490, 238);
            searchGrid.TabIndex = 37;
            // 
            // searchField
            // 
            searchField.BackColor = SystemColors.ControlLightLight;
            searchField.BorderStyle = BorderStyle.FixedSingle;
            searchField.Font = new Font("Segoe UI", 13.8F);
            searchField.Location = new Point(136, 29);
            searchField.Margin = new Padding(3, 2, 3, 2);
            searchField.Multiline = true;
            searchField.Name = "searchField";
            searchField.Size = new Size(379, 31);
            searchField.TabIndex = 36;
            searchField.TextChanged += searchField_TextChanged_1;
            // 
            // SearchLabel
            // 
            SearchLabel.AutoSize = true;
            SearchLabel.BackColor = SystemColors.ActiveCaption;
            SearchLabel.Font = new Font("Impact", 19.8F);
            SearchLabel.Location = new Point(24, 29);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(104, 34);
            SearchLabel.TabIndex = 35;
            SearchLabel.Text = "Search :";
            // 
            // mViewUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(backButton);
            Controls.Add(searchGrid);
            Controls.Add(searchField);
            Controls.Add(SearchLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "mViewUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mViewUser";
            Load += mViewUser_Load;
            ((System.ComponentModel.ISupportInitialize)searchGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private DataGridView searchGrid;
        private TextBox searchField;
        private Label SearchLabel;
    }
}