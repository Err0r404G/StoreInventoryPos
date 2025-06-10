using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace StoreInventoryPos
{
    partial class modifyUser
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
            SearchLabel = new Label();
            fNameLabel = new Label();
            usernamelabel = new Label();
            passLabel = new Label();
            userNameField = new TextBox();
            fullNameField = new TextBox();
            passwordField = new TextBox();
            deleteButton = new Button();
            updateButton = new Button();
            roleBox = new ComboBox();
            roleLabel = new Label();
            searchGrid = new DataGridView();
            backButton = new Button();
            clearButton = new Button();
            ((System.ComponentModel.ISupportInitialize)searchGrid).BeginInit();
            SuspendLayout();
            // 
            // searchField
            // 
            searchField.BackColor = SystemColors.ControlLightLight;
            searchField.BorderStyle = BorderStyle.FixedSingle;
            searchField.Font = new Font("Segoe UI", 13.8F);
            searchField.Location = new Point(134, 22);
            searchField.Margin = new Padding(3, 2, 3, 2);
            searchField.Multiline = true;
            searchField.Name = "searchField";
            searchField.Size = new Size(411, 34);
            searchField.TabIndex = 17;
            searchField.TextChanged += searchField_TextChanged;
            // 
            // SearchLabel
            // 
            SearchLabel.AutoSize = true;
            SearchLabel.BackColor = SystemColors.ActiveCaption;
            SearchLabel.Font = new Font("Impact", 19.8F);
            SearchLabel.Location = new Point(34, 22);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(99, 34);
            SearchLabel.TabIndex = 16;
            SearchLabel.Text = "Search ";
            // 
            // fNameLabel
            // 
            fNameLabel.AutoSize = true;
            fNameLabel.BackColor = SystemColors.ActiveCaption;
            fNameLabel.Font = new Font("Impact", 19.8F);
            fNameLabel.Location = new Point(620, 130);
            fNameLabel.Name = "fNameLabel";
            fNameLabel.Size = new Size(128, 34);
            fNameLabel.TabIndex = 18;
            fNameLabel.Text = "Full Name ";
            // 
            // usernamelabel
            // 
            usernamelabel.AutoSize = true;
            usernamelabel.BackColor = SystemColors.ActiveCaption;
            usernamelabel.Font = new Font("Impact", 19.8F);
            usernamelabel.Location = new Point(620, 78);
            usernamelabel.Name = "usernamelabel";
            usernamelabel.Size = new Size(130, 34);
            usernamelabel.TabIndex = 19;
            usernamelabel.Text = "Username";
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.BackColor = SystemColors.ActiveCaption;
            passLabel.Font = new Font("Impact", 19.8F);
            passLabel.Location = new Point(620, 183);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(129, 34);
            passLabel.TabIndex = 20;
            passLabel.Text = "Password ";
            // 
            // userNameField
            // 
            userNameField.BackColor = SystemColors.Info;
            userNameField.BorderStyle = BorderStyle.FixedSingle;
            userNameField.Font = new Font("Segoe UI", 13.8F);
            userNameField.ForeColor = SystemColors.InfoText;
            userNameField.Location = new Point(743, 78);
            userNameField.Margin = new Padding(3, 2, 3, 2);
            userNameField.Multiline = true;
            userNameField.Name = "userNameField";
            userNameField.ReadOnly = true;
            userNameField.Size = new Size(201, 34);
            userNameField.TabIndex = 21;
            // 
            // fullNameField
            // 
            fullNameField.BackColor = SystemColors.ControlLightLight;
            fullNameField.BorderStyle = BorderStyle.FixedSingle;
            fullNameField.Font = new Font("Segoe UI", 13.8F);
            fullNameField.Location = new Point(743, 130);
            fullNameField.Margin = new Padding(3, 2, 3, 2);
            fullNameField.Multiline = true;
            fullNameField.Name = "fullNameField";
            fullNameField.Size = new Size(201, 34);
            fullNameField.TabIndex = 22;
            // 
            // passwordField
            // 
            passwordField.BackColor = SystemColors.ControlLightLight;
            passwordField.BorderStyle = BorderStyle.FixedSingle;
            passwordField.Font = new Font("Segoe UI", 13.8F);
            passwordField.Location = new Point(743, 183);
            passwordField.Margin = new Padding(3, 2, 3, 2);
            passwordField.Multiline = true;
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(201, 34);
            passwordField.TabIndex = 23;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Red;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.Font = new Font("Impact", 15.75F);
            deleteButton.ForeColor = Color.LavenderBlush;
            deleteButton.Location = new Point(806, 285);
            deleteButton.Margin = new Padding(3, 2, 3, 2);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(138, 36);
            deleteButton.TabIndex = 24;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.FromArgb(128, 255, 128);
            updateButton.Cursor = Cursors.Hand;
            updateButton.FlatStyle = FlatStyle.Popup;
            updateButton.Font = new Font("Impact", 15.75F);
            updateButton.ForeColor = Color.Black;
            updateButton.Location = new Point(633, 285);
            updateButton.Margin = new Padding(3, 2, 3, 2);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(138, 36);
            updateButton.TabIndex = 25;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // roleBox
            // 
            roleBox.FormattingEnabled = true;
            roleBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roleBox.Items.AddRange(new object[] { "ADMIN", "MANAGER", "STAFF" });
            roleBox.Location = new Point(743, 232);
            roleBox.Margin = new Padding(3, 2, 3, 2);
            roleBox.Name = "roleBox";
            roleBox.Size = new Size(143, 23);
            roleBox.TabIndex = 27;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Impact", 13.8F);
            roleLabel.Location = new Point(645, 232);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(100, 23);
            roleLabel.TabIndex = 26;
            roleLabel.Text = "Assign Role";
            // 
            // searchGrid
            // 
            searchGrid.AllowUserToAddRows = false;
            searchGrid.AllowUserToDeleteRows = false;
            searchGrid.AllowUserToOrderColumns = true;
            searchGrid.AllowUserToResizeRows = false;
            searchGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            searchGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchGrid.Location = new Point(34, 68);
            searchGrid.Margin = new Padding(3, 2, 3, 2);
            searchGrid.MultiSelect = false;
            searchGrid.Name = "searchGrid";
            searchGrid.ReadOnly = true;
            searchGrid.RowHeadersVisible = false;
            searchGrid.RowHeadersWidth = 51;
            searchGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            searchGrid.ScrollBars = ScrollBars.Vertical;
            searchGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            searchGrid.Size = new Size(511, 238);
            searchGrid.TabIndex = 29;
            searchGrid.CellClick += searchGrid_CellClick;
            // 
            // backButton
            // 
            backButton.BackColor = Color.White;
            backButton.Cursor = Cursors.Hand;
            backButton.FlatStyle = FlatStyle.Popup;
            backButton.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.Crimson;
            backButton.Location = new Point(988, 23);
            backButton.Margin = new Padding(3, 2, 3, 2);
            backButton.Name = "backButton";
            backButton.Size = new Size(98, 38);
            backButton.TabIndex = 30;
            backButton.Text = "BACK";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click_1;
            // 
            // clearButton
            // 
            clearButton.BackColor = SystemColors.WindowText;
            clearButton.Cursor = Cursors.Hand;
            clearButton.FlatStyle = FlatStyle.Popup;
            clearButton.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearButton.ForeColor = Color.LavenderBlush;
            clearButton.Location = new Point(718, 337);
            clearButton.Margin = new Padding(3, 2, 3, 2);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(138, 36);
            clearButton.TabIndex = 36;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // modifyUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 403);
            Controls.Add(clearButton);
            Controls.Add(backButton);
            Controls.Add(searchGrid);
            Controls.Add(roleBox);
            Controls.Add(roleLabel);
            Controls.Add(updateButton);
            Controls.Add(deleteButton);
            Controls.Add(passwordField);
            Controls.Add(fullNameField);
            Controls.Add(userNameField);
            Controls.Add(passLabel);
            Controls.Add(usernamelabel);
            Controls.Add(fNameLabel);
            Controls.Add(searchField);
            Controls.Add(SearchLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "modifyUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modify User";
            ((System.ComponentModel.ISupportInitialize)searchGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox searchField;
        private Label SearchLabel;
        private Label fNameLabel;
        private Label usernamelabel;
        private Label passLabel;
        private TextBox userNameField;
        private TextBox fullNameField;
        private TextBox passwordField;
        private Button deleteButton;
        private Button updateButton;
        private ComboBox roleBox;
        private Label roleLabel;
        private DataGridView searchGrid;
        private Button backButton;
        private Button clearButton;
    }
}
