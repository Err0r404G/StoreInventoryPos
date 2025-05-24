namespace StoreInventoryPos
{
    partial class PromoCode
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
            promoField = new TextBox();
            label1 = new Label();
            backButton = new Button();
            searchGrid = new DataGridView();
            deleteButton = new Button();
            discountField = new TextBox();
            promoLabel = new Label();
            discountLabl = new Label();
            deleteLabl = new Label();
            deletePanel = new Panel();
            searchButton = new Button();
            searchField = new TextBox();
            createPanel = new Panel();
            label5 = new Label();
            promoBox = new TextBox();
            label6 = new Label();
            addButton = new Button();
            discountBox = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)searchGrid).BeginInit();
            deletePanel.SuspendLayout();
            createPanel.SuspendLayout();
            SuspendLayout();
            // 
            // promoField
            // 
            promoField.BackColor = SystemColors.Info;
            promoField.BorderStyle = BorderStyle.FixedSingle;
            promoField.Font = new Font("Segoe UI", 13.8F);
            promoField.Location = new Point(237, 63);
            promoField.Multiline = true;
            promoField.Name = "promoField";
            promoField.ReadOnly = true;
            promoField.Size = new Size(190, 42);
            promoField.TabIndex = 91;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Impact", 19.8F);
            label1.Location = new Point(26, 43);
            label1.Name = "label1";
            label1.Size = new Size(127, 41);
            label1.TabIndex = 88;
            label1.Text = "Search :";
            // 
            // backButton
            // 
            backButton.BackColor = Color.White;
            backButton.Cursor = Cursors.Hand;
            backButton.FlatStyle = FlatStyle.Popup;
            backButton.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.Crimson;
            backButton.Location = new Point(907, 9);
            backButton.Name = "backButton";
            backButton.Size = new Size(149, 51);
            backButton.TabIndex = 87;
            backButton.Text = "BACK";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // searchGrid
            // 
            searchGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchGrid.Location = new Point(159, 98);
            searchGrid.Name = "searchGrid";
            searchGrid.RowHeadersWidth = 51;
            searchGrid.Size = new Size(302, 555);
            searchGrid.TabIndex = 86;
            searchGrid.CellClick += searchGrid_CellClick_1;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Red;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.Font = new Font("Impact", 19.8F);
            deleteButton.ForeColor = Color.LavenderBlush;
            deleteButton.Location = new Point(174, 206);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(158, 48);
            deleteButton.TabIndex = 83;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // discountField
            // 
            discountField.BackColor = SystemColors.ControlLightLight;
            discountField.BorderStyle = BorderStyle.FixedSingle;
            discountField.Font = new Font("Segoe UI", 13.8F);
            discountField.Location = new Point(237, 124);
            discountField.Multiline = true;
            discountField.Name = "discountField";
            discountField.Size = new Size(190, 42);
            discountField.TabIndex = 81;
            // 
            // promoLabel
            // 
            promoLabel.AutoSize = true;
            promoLabel.BackColor = Color.Transparent;
            promoLabel.Font = new Font("Impact", 19.8F);
            promoLabel.Location = new Point(14, 63);
            promoLabel.Name = "promoLabel";
            promoLabel.Size = new Size(175, 41);
            promoLabel.TabIndex = 80;
            promoLabel.Text = "PromoCode";
            // 
            // discountLabl
            // 
            discountLabl.AutoSize = true;
            discountLabl.BackColor = Color.Transparent;
            discountLabl.Font = new Font("Impact", 19.8F);
            discountLabl.Location = new Point(51, 124);
            discountLabl.Name = "discountLabl";
            discountLabl.Size = new Size(138, 41);
            discountLabl.TabIndex = 92;
            discountLabl.Text = "Discount";
            // 
            // deleteLabl
            // 
            deleteLabl.AutoSize = true;
            deleteLabl.BackColor = Color.Transparent;
            deleteLabl.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteLabl.ForeColor = Color.IndianRed;
            deleteLabl.Location = new Point(161, 9);
            deleteLabl.Name = "deleteLabl";
            deleteLabl.Size = new Size(202, 42);
            deleteLabl.TabIndex = 93;
            deleteLabl.Text = "Delete Promo";
            deleteLabl.TextAlign = ContentAlignment.TopCenter;
            // 
            // deletePanel
            // 
            deletePanel.BackColor = Color.LemonChiffon;
            deletePanel.Controls.Add(promoLabel);
            deletePanel.Controls.Add(deleteLabl);
            deletePanel.Controls.Add(discountField);
            deletePanel.Controls.Add(discountLabl);
            deletePanel.Controls.Add(deleteButton);
            deletePanel.Controls.Add(promoField);
            deletePanel.Location = new Point(567, 377);
            deletePanel.Name = "deletePanel";
            deletePanel.Size = new Size(484, 276);
            deletePanel.TabIndex = 94;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.Red;
            searchButton.Cursor = Cursors.Hand;
            searchButton.FlatStyle = FlatStyle.Popup;
            searchButton.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.LavenderBlush;
            searchButton.Location = new Point(467, 42);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(70, 42);
            searchButton.TabIndex = 96;
            searchButton.Text = "GO";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click_1;
            // 
            // searchField
            // 
            searchField.BackColor = SystemColors.ControlLightLight;
            searchField.BorderStyle = BorderStyle.FixedSingle;
            searchField.Font = new Font("Segoe UI", 13.8F);
            searchField.Location = new Point(159, 42);
            searchField.Multiline = true;
            searchField.Name = "searchField";
            searchField.Size = new Size(302, 42);
            searchField.TabIndex = 95;
            // 
            // createPanel
            // 
            createPanel.BackColor = Color.LemonChiffon;
            createPanel.Controls.Add(label5);
            createPanel.Controls.Add(promoBox);
            createPanel.Controls.Add(label6);
            createPanel.Controls.Add(addButton);
            createPanel.Controls.Add(discountBox);
            createPanel.Controls.Add(label7);
            createPanel.Location = new Point(567, 66);
            createPanel.Name = "createPanel";
            createPanel.Size = new Size(489, 259);
            createPanel.TabIndex = 100;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Impact", 19.8F);
            label5.Location = new Point(16, 57);
            label5.Name = "label5";
            label5.Size = new Size(175, 41);
            label5.TabIndex = 94;
            label5.Text = "PromoCode";
            // 
            // promoBox
            // 
            promoBox.BackColor = SystemColors.ControlLightLight;
            promoBox.BorderStyle = BorderStyle.FixedSingle;
            promoBox.Font = new Font("Segoe UI", 13.8F);
            promoBox.Location = new Point(239, 57);
            promoBox.Multiline = true;
            promoBox.Name = "promoBox";
            promoBox.Size = new Size(190, 42);
            promoBox.TabIndex = 97;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SeaGreen;
            label6.Location = new Point(163, 3);
            label6.Name = "label6";
            label6.Size = new Size(205, 42);
            label6.TabIndex = 99;
            label6.Text = "Create Promo";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // addButton
            // 
            addButton.BackColor = Color.MediumSeaGreen;
            addButton.Cursor = Cursors.Hand;
            addButton.FlatStyle = FlatStyle.Popup;
            addButton.Font = new Font("Impact", 19.8F);
            addButton.ForeColor = Color.Black;
            addButton.Location = new Point(176, 200);
            addButton.Name = "addButton";
            addButton.Size = new Size(158, 48);
            addButton.TabIndex = 96;
            addButton.Text = "ADD";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // discountBox
            // 
            discountBox.BackColor = SystemColors.ControlLightLight;
            discountBox.BorderStyle = BorderStyle.FixedSingle;
            discountBox.Font = new Font("Segoe UI", 13.8F);
            discountBox.Location = new Point(239, 118);
            discountBox.Multiline = true;
            discountBox.Name = "discountBox";
            discountBox.Size = new Size(190, 42);
            discountBox.TabIndex = 95;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Impact", 19.8F);
            label7.Location = new Point(53, 118);
            label7.Name = "label7";
            label7.Size = new Size(138, 41);
            label7.TabIndex = 98;
            label7.Text = "Discount";
            // 
            // PromoCode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 720);
            Controls.Add(deletePanel);
            Controls.Add(createPanel);
            Controls.Add(searchButton);
            Controls.Add(searchField);
            Controls.Add(label1);
            Controls.Add(backButton);
            Controls.Add(searchGrid);
            Name = "PromoCode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Promo Code";
            Load += createPromo_Load;
            ((System.ComponentModel.ISupportInitialize)searchGrid).EndInit();
            deletePanel.ResumeLayout(false);
            deletePanel.PerformLayout();
            createPanel.ResumeLayout(false);
            createPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox promoField;
        private Label label1;
        private Button backButton;
        private DataGridView searchGrid;
        private Button deleteButton;
        private TextBox discountField;
        private Label promoLabel;
        private Label discountLabl;
        private Label deleteLabl;
        private Panel deletePanel;
        private Button searchButton;
        private TextBox searchField;
        private Panel createPanel;
        private Label label5;
        private TextBox promoBox;
        private Label label6;
        private Button addButton;
        private TextBox discountBox;
        private Label label7;
    }
}