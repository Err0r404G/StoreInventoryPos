namespace StoreInventoryPos
{
    partial class refundReport
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
        /// 


        private void InitializeComponent()
        {
            searchGrid = new DataGridView();
            exportButton = new Button();
            printButton = new Button();
            backButton = new Button();
            clearButton = new Button();
            label1 = new Label();
            searchField = new TextBox();
            ((System.ComponentModel.ISupportInitialize)searchGrid).BeginInit();
            SuspendLayout();
            // 
            // searchGrid
            // 
            searchGrid.AllowUserToAddRows = false;
            searchGrid.AllowUserToDeleteRows = false;
            searchGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            searchGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchGrid.Location = new Point(40, 90);
            searchGrid.Name = "searchGrid";
            searchGrid.ReadOnly = true;
            searchGrid.RowHeadersWidth = 51;
            searchGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            searchGrid.Size = new Size(1200, 400);
            searchGrid.TabIndex = 3;
            // 
            // exportButton
            // 
            exportButton.BackColor = Color.LightSkyBlue;
            exportButton.Font = new Font("Impact", 18F);
            exportButton.Location = new Point(40, 510);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(150, 50);
            exportButton.TabIndex = 4;
            exportButton.Text = "Export";
            exportButton.UseVisualStyleBackColor = false;
            // 
            // printButton
            // 
            printButton.BackColor = Color.Khaki;
            printButton.Font = new Font("Impact", 18F);
            printButton.Location = new Point(196, 510);
            printButton.Name = "printButton";
            printButton.Size = new Size(150, 50);
            printButton.TabIndex = 5;
            printButton.Text = "Print";
            printButton.UseVisualStyleBackColor = false;
            // 
            // backButton
            // 
            backButton.BackColor = Color.White;
            backButton.Font = new Font("Impact", 18F);
            backButton.ForeColor = Color.Crimson;
            backButton.Location = new Point(1120, 30);
            backButton.Name = "backButton";
            backButton.Size = new Size(120, 50);
            backButton.TabIndex = 17;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Black;
            clearButton.Font = new Font("Impact", 18F);
            clearButton.ForeColor = Color.White;
            clearButton.Location = new Point(352, 510);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(150, 50);
            clearButton.TabIndex = 18;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Impact", 19.8F);
            label1.Location = new Point(40, 30);
            label1.Name = "label1";
            label1.Size = new Size(127, 41);
            label1.TabIndex = 19;
            label1.Text = "Search :";
            // 
            // searchField
            // 
            searchField.BackColor = SystemColors.ControlLightLight;
            searchField.BorderStyle = BorderStyle.FixedSingle;
            searchField.Font = new Font("Segoe UI", 13.8F);
            searchField.Location = new Point(173, 30);
            searchField.Multiline = true;
            searchField.Name = "searchField";
            searchField.Size = new Size(438, 42);
            searchField.TabIndex = 37;
            // 
            // refundReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 580);
            Controls.Add(searchField);
            Controls.Add(label1);
            Controls.Add(clearButton);
            Controls.Add(backButton);
            Controls.Add(searchGrid);
            Controls.Add(exportButton);
            Controls.Add(printButton);
            Name = "refundReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Refund Report";
            ((System.ComponentModel.ISupportInitialize)searchGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private DataGridView searchGrid;
            private Button exportButton;
            private Button printButton;
        #endregion

        private Button backButton;
        private Button clearButton;
        private Label label1;
        private TextBox searchField;
    }
}