namespace StoreInventoryPos
{
    partial class modifyProduct
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
            SearchLabel = new Label();
            backButton = new Button();
            searchGrid = new DataGridView();
            searchButton = new Button();
            sizeBox = new ComboBox();
            roleLabel = new Label();
            updateButton = new Button();
            deleteButton = new Button();
            costField = new TextBox();
            costLabel = new Label();
            productIDlabel = new Label();
            productNameLabel = new Label();
            searchField = new TextBox();
            label1 = new Label();
            QuantityField = new TextBox();
            priceField = new TextBox();
            quantityLabel = new Label();
            priceLabel = new Label();
            ProductNameField = new TextBox();
            productIDField = new TextBox();
            ((System.ComponentModel.ISupportInitialize)searchGrid).BeginInit();
            SuspendLayout();
            // 
            // SearchLabel
            // 
            SearchLabel.AutoSize = true;
            SearchLabel.BackColor = SystemColors.ActiveCaption;
            SearchLabel.Font = new Font("Impact", 19.8F);
            SearchLabel.Location = new Point(-194, 27);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(127, 41);
            SearchLabel.TabIndex = 31;
            SearchLabel.Text = "Search :";
            // 
            // backButton
            // 
            backButton.BackColor = Color.White;
            backButton.Cursor = Cursors.Hand;
            backButton.FlatStyle = FlatStyle.Popup;
            backButton.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.Crimson;
            backButton.Location = new Point(1241, 47);
            backButton.Name = "backButton";
            backButton.Size = new Size(112, 51);
            backButton.TabIndex = 73;
            backButton.Text = "BACK";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // searchGrid
            // 
            searchGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchGrid.Location = new Point(69, 110);
            searchGrid.Name = "searchGrid";
            searchGrid.RowHeadersWidth = 51;
            searchGrid.Size = new Size(842, 415);
            searchGrid.TabIndex = 72;
            searchGrid.CellClick += searchGrid_CellClick;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.Red;
            searchButton.Cursor = Cursors.Hand;
            searchButton.FlatStyle = FlatStyle.Popup;
            searchButton.Font = new Font("Impact", 19.8F);
            searchButton.ForeColor = Color.LavenderBlush;
            searchButton.Location = new Point(609, 47);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(69, 42);
            searchButton.TabIndex = 71;
            searchButton.Text = "GO";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // sizeBox
            // 
            sizeBox.FormattingEnabled = true;
            sizeBox.Items.AddRange(new object[] { "38", "39", "40", "41", "42", "43", "44" });
            sizeBox.Location = new Point(1124, 471);
            sizeBox.Name = "sizeBox";
            sizeBox.Size = new Size(163, 28);
            sizeBox.TabIndex = 70;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Impact", 13.8F);
            roleLabel.Location = new Point(1074, 471);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(50, 28);
            roleLabel.TabIndex = 69;
            roleLabel.Text = "Size";
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.FromArgb(128, 255, 128);
            updateButton.Cursor = Cursors.Hand;
            updateButton.FlatStyle = FlatStyle.Popup;
            updateButton.Font = new Font("Impact", 19.8F);
            updateButton.ForeColor = Color.Black;
            updateButton.Location = new Point(996, 567);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(158, 48);
            updateButton.TabIndex = 68;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Red;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.Font = new Font("Impact", 19.8F);
            deleteButton.ForeColor = Color.LavenderBlush;
            deleteButton.Location = new Point(1194, 567);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(158, 48);
            deleteButton.TabIndex = 67;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // costField
            // 
            costField.BackColor = SystemColors.ControlLightLight;
            costField.BorderStyle = BorderStyle.FixedSingle;
            costField.Font = new Font("Segoe UI", 13.8F);
            costField.Location = new Point(1124, 265);
            costField.Multiline = true;
            costField.Name = "costField";
            costField.Size = new Size(229, 42);
            costField.TabIndex = 66;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.BackColor = SystemColors.Control;
            costLabel.Font = new Font("Impact", 19.8F);
            costLabel.Location = new Point(1046, 265);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(79, 41);
            costLabel.TabIndex = 63;
            costLabel.Text = "Cost";
            // 
            // productIDlabel
            // 
            productIDlabel.AutoSize = true;
            productIDlabel.BackColor = SystemColors.Control;
            productIDlabel.Font = new Font("Impact", 19.8F);
            productIDlabel.Location = new Point(968, 125);
            productIDlabel.Name = "productIDlabel";
            productIDlabel.Size = new Size(157, 41);
            productIDlabel.TabIndex = 62;
            productIDlabel.Text = "Product ID";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.BackColor = SystemColors.Control;
            productNameLabel.Font = new Font("Impact", 19.8F);
            productNameLabel.Location = new Point(1029, 194);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(95, 41);
            productNameLabel.TabIndex = 61;
            productNameLabel.Text = "Name";
            // 
            // searchField
            // 
            searchField.BackColor = SystemColors.ControlLightLight;
            searchField.BorderStyle = BorderStyle.FixedSingle;
            searchField.Font = new Font("Segoe UI", 13.8F);
            searchField.Location = new Point(208, 47);
            searchField.Multiline = true;
            searchField.Name = "searchField";
            searchField.Size = new Size(382, 42);
            searchField.TabIndex = 60;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Impact", 19.8F);
            label1.Location = new Point(69, 47);
            label1.Name = "label1";
            label1.Size = new Size(127, 41);
            label1.TabIndex = 74;
            label1.Text = "Search :";
            // 
            // QuantityField
            // 
            QuantityField.BackColor = SystemColors.ControlLightLight;
            QuantityField.BorderStyle = BorderStyle.FixedSingle;
            QuantityField.Font = new Font("Segoe UI", 13.8F);
            QuantityField.Location = new Point(1123, 408);
            QuantityField.Multiline = true;
            QuantityField.Name = "QuantityField";
            QuantityField.Size = new Size(229, 42);
            QuantityField.TabIndex = 78;
            // 
            // priceField
            // 
            priceField.BackColor = SystemColors.ControlLightLight;
            priceField.BorderStyle = BorderStyle.FixedSingle;
            priceField.Font = new Font("Segoe UI", 13.8F);
            priceField.Location = new Point(1123, 337);
            priceField.Multiline = true;
            priceField.Name = "priceField";
            priceField.Size = new Size(229, 42);
            priceField.TabIndex = 77;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.BackColor = SystemColors.Control;
            quantityLabel.Font = new Font("Impact", 19.8F);
            quantityLabel.Location = new Point(992, 408);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(132, 41);
            quantityLabel.TabIndex = 76;
            quantityLabel.Text = "Quantity";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.BackColor = SystemColors.Control;
            priceLabel.Font = new Font("Impact", 19.8F);
            priceLabel.Location = new Point(1035, 338);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(89, 41);
            priceLabel.TabIndex = 75;
            priceLabel.Text = "Price";
            // 
            // ProductNameField
            // 
            ProductNameField.BackColor = SystemColors.ControlLightLight;
            ProductNameField.BorderStyle = BorderStyle.FixedSingle;
            ProductNameField.Font = new Font("Segoe UI", 13.8F);
            ProductNameField.Location = new Point(1123, 194);
            ProductNameField.Multiline = true;
            ProductNameField.Name = "ProductNameField";
            ProductNameField.Size = new Size(229, 42);
            ProductNameField.TabIndex = 65;
            // 
            // productIDField
            // 
            productIDField.BackColor = SystemColors.Info;
            productIDField.BorderStyle = BorderStyle.FixedSingle;
            productIDField.Font = new Font("Segoe UI", 13.8F);
            productIDField.Location = new Point(1124, 124);
            productIDField.Multiline = true;
            productIDField.Name = "productIDField";
            productIDField.ReadOnly = true;
            productIDField.Size = new Size(229, 42);
            productIDField.TabIndex = 79;
            // 
            // modifyProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1404, 757);
            Controls.Add(productIDField);
            Controls.Add(QuantityField);
            Controls.Add(priceField);
            Controls.Add(quantityLabel);
            Controls.Add(priceLabel);
            Controls.Add(label1);
            Controls.Add(backButton);
            Controls.Add(searchGrid);
            Controls.Add(searchButton);
            Controls.Add(sizeBox);
            Controls.Add(roleLabel);
            Controls.Add(updateButton);
            Controls.Add(deleteButton);
            Controls.Add(costField);
            Controls.Add(ProductNameField);
            Controls.Add(costLabel);
            Controls.Add(productIDlabel);
            Controls.Add(productNameLabel);
            Controls.Add(searchField);
            Controls.Add(SearchLabel);
            Name = "modifyProduct";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Modify Product";
            ((System.ComponentModel.ISupportInitialize)searchGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SearchLabel;
        private Button backButton;
        private DataGridView searchGrid;
        private Button searchButton;
        private ComboBox sizeBox;
        private Label roleLabel;
        private Button updateButton;
        private Button deleteButton;
        private TextBox costField;
        private TextBox fullNameField;
        private TextBox userNameField;
        private Label costLabel;
        private Label productIDlabel;
        private Label productNameLabel;
        private TextBox searchField;
        private Label label1;
        private TextBox QuantityField;
        private TextBox priceField;
        private Label quantityLabel;
        private Label priceLabel;
        private TextBox ProductNameField;
        private TextBox productIDField;
    }
}