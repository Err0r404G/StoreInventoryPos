namespace StoreInventoryPos
{
    partial class selectionCart
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
            dataGridView1 = new DataGridView();
            searchField = new TextBox();
            label1 = new Label();
            clearButton = new Button();
            exportButton = new Button();
            backButton = new Button();
            cartLabel = new Label();
            button1 = new Button();
            addButton = new Button();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(641, 411);
            dataGridView1.TabIndex = 0;
            // 
            // searchField
            // 
            searchField.BackColor = SystemColors.ControlLightLight;
            searchField.BorderStyle = BorderStyle.FixedSingle;
            searchField.Font = new Font("Segoe UI", 13.8F);
            searchField.Location = new Point(155, 42);
            searchField.Multiline = true;
            searchField.Name = "searchField";
            searchField.Size = new Size(508, 42);
            searchField.TabIndex = 39;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Impact", 19.8F);
            label1.Location = new Point(22, 42);
            label1.Name = "label1";
            label1.Size = new Size(641, 41);
            label1.TabIndex = 38;
            label1.Text = "Search :";
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Black;
            clearButton.Cursor = Cursors.Hand;
            clearButton.Font = new Font("Impact", 18F);
            clearButton.ForeColor = Color.White;
            clearButton.Location = new Point(178, 535);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(150, 50);
            clearButton.TabIndex = 42;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            // 
            // exportButton
            // 
            exportButton.BackColor = Color.LightSkyBlue;
            exportButton.Cursor = Cursors.Hand;
            exportButton.Font = new Font("Impact", 18F);
            exportButton.Location = new Point(22, 535);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(150, 50);
            exportButton.TabIndex = 40;
            exportButton.Text = "Next";
            exportButton.UseVisualStyleBackColor = false;
            // 
            // backButton
            // 
            backButton.BackColor = Color.Snow;
            backButton.Cursor = Cursors.Hand;
            backButton.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.Crimson;
            backButton.Location = new Point(334, 535);
            backButton.Name = "backButton";
            backButton.Size = new Size(150, 50);
            backButton.TabIndex = 43;
            backButton.Text = "BACK";
            backButton.UseVisualStyleBackColor = false;
            // 
            // cartLabel
            // 
            cartLabel.BackColor = SystemColors.Desktop;
            cartLabel.Font = new Font("Impact", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cartLabel.ForeColor = Color.FloralWhite;
            cartLabel.Location = new Point(912, 25);
            cartLabel.Name = "cartLabel";
            cartLabel.Size = new Size(439, 69);
            cartLabel.TabIndex = 44;
            cartLabel.Text = "Cart";
            cartLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.Firebrick;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Impact", 18F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(704, 227);
            button1.Name = "button1";
            button1.Size = new Size(161, 50);
            button1.TabIndex = 46;
            button1.Text = "<<Remove";
            button1.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            addButton.AutoSize = true;
            addButton.BackColor = Color.OliveDrab;
            addButton.Cursor = Cursors.Hand;
            addButton.Font = new Font("Impact", 18F);
            addButton.Location = new Point(704, 146);
            addButton.Name = "addButton";
            addButton.Size = new Size(150, 50);
            addButton.TabIndex = 45;
            addButton.Text = "ADD>>";
            addButton.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(912, 97);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(439, 411);
            dataGridView2.TabIndex = 1;
            // 
            // selectionCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1377, 646);
            Controls.Add(button1);
            Controls.Add(addButton);
            Controls.Add(cartLabel);
            Controls.Add(backButton);
            Controls.Add(clearButton);
            Controls.Add(exportButton);
            Controls.Add(searchField);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "selectionCart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Selection";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox searchField;
        private Label label1;
        private Button clearButton;
        private Button exportButton;
        private Button backButton;
        private Label cartLabel;
        private Button button1;
        private Button addButton;
        private DataGridView dataGridView2;
    }
}