namespace StoreInventoryPos
{
    partial class viewUser
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
            searchGrid = new DataGridView();
            searchField = new TextBox();
            SearchLabel = new Label();
            backButton = new Button();
            clearButton = new Button();
            ((System.ComponentModel.ISupportInitialize)searchGrid).BeginInit();
            SuspendLayout();
            // 
            // searchGrid
            // 
            searchGrid.AllowUserToAddRows = false;
            searchGrid.AllowUserToDeleteRows = false;
            searchGrid.AllowUserToResizeRows = false;
            searchGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            searchGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchGrid.Location = new Point(32, 88);
            searchGrid.Name = "searchGrid";
            searchGrid.RowHeadersWidth = 51;
            searchGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            searchGrid.Size = new Size(560, 318);
            searchGrid.TabIndex = 33;
            // 
            // searchField
            // 
            searchField.BackColor = SystemColors.ControlLightLight;
            searchField.BorderStyle = BorderStyle.FixedSingle;
            searchField.Font = new Font("Segoe UI", 13.8F);
            searchField.Location = new Point(159, 29);
            searchField.Multiline = true;
            searchField.Name = "searchField";
            searchField.Size = new Size(326, 42);
            searchField.TabIndex = 31;
            searchField.TextChanged += searchField_TextChanged;
            // 
            // SearchLabel
            // 
            SearchLabel.AutoSize = true;
            SearchLabel.BackColor = SystemColors.ActiveCaption;
            SearchLabel.Font = new Font("Impact", 19.8F);
            SearchLabel.Location = new Point(32, 29);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(127, 41);
            SearchLabel.TabIndex = 30;
            SearchLabel.Text = "Search :";
            // 
            // backButton
            // 
            backButton.BackColor = Color.White;
            backButton.Cursor = Cursors.Hand;
            backButton.FlatStyle = FlatStyle.Popup;
            backButton.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.Crimson;
            backButton.Location = new Point(665, 24);
            backButton.Name = "backButton";
            backButton.Size = new Size(112, 51);
            backButton.TabIndex = 34;
            backButton.Text = "BACK";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Red;
            clearButton.Cursor = Cursors.Hand;
            clearButton.FlatStyle = FlatStyle.Popup;
            clearButton.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearButton.ForeColor = Color.LavenderBlush;
            clearButton.Location = new Point(482, 29);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(110, 42);
            clearButton.TabIndex = 35;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            // 
            // viewUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clearButton);
            Controls.Add(backButton);
            Controls.Add(searchGrid);
            Controls.Add(searchField);
            Controls.Add(SearchLabel);
            Name = "viewUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View User";
            ((System.ComponentModel.ISupportInitialize)searchGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView searchGrid;
        private TextBox searchField;
        private Label SearchLabel;
        private Button backButton;
        private Button clearButton;
    }
}