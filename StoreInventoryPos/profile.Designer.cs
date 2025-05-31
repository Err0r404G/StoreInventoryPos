namespace StoreInventoryPos
{
    partial class profile
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
            profileLabel = new Label();
            backButton = new Button();
            label1 = new Label();
            userName = new Label();
            fullName = new Label();
            fnameField = new TextBox();
            usernameField = new TextBox();
            RoleField = new TextBox();
            SuspendLayout();
            // 
            // profileLabel
            // 
            profileLabel.AutoSize = true;
            profileLabel.BackColor = Color.Transparent;
            profileLabel.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            profileLabel.ForeColor = SystemColors.MenuText;
            profileLabel.Location = new Point(229, 28);
            profileLabel.Name = "profileLabel";
            profileLabel.Size = new Size(154, 42);
            profileLabel.TabIndex = 8;
            profileLabel.Text = "My Profile";
            profileLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // backButton
            // 
            backButton.BackColor = Color.White;
            backButton.Cursor = Cursors.Hand;
            backButton.FlatStyle = FlatStyle.Popup;
            backButton.Font = new Font("Impact", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.ForeColor = Color.Crimson;
            backButton.Location = new Point(478, 19);
            backButton.Name = "backButton";
            backButton.Size = new Size(111, 51);
            backButton.TabIndex = 17;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 16.2F);
            label1.Location = new Point(38, 274);
            label1.Name = "label1";
            label1.Size = new Size(65, 35);
            label1.TabIndex = 21;
            label1.Text = "Role";
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Font = new Font("Impact", 16.2F);
            userName.Location = new Point(38, 182);
            userName.Name = "userName";
            userName.Size = new Size(137, 35);
            userName.TabIndex = 20;
            userName.Text = "User Name";
            // 
            // fullName
            // 
            fullName.AutoSize = true;
            fullName.Font = new Font("Impact", 16.2F);
            fullName.Location = new Point(38, 90);
            fullName.Name = "fullName";
            fullName.Size = new Size(125, 35);
            fullName.TabIndex = 19;
            fullName.Text = "Full Name";
            // 
            // fnameField
            // 
            fnameField.BackColor = SystemColors.Info;
            fnameField.BorderStyle = BorderStyle.FixedSingle;
            fnameField.Font = new Font("Segoe UI", 19.8000011F);
            fnameField.Location = new Point(38, 128);
            fnameField.Name = "fnameField";
            fnameField.ReadOnly = true;
            fnameField.Size = new Size(290, 51);
            fnameField.TabIndex = 18;
            // 
            // usernameField
            // 
            usernameField.BackColor = SystemColors.Info;
            usernameField.BorderStyle = BorderStyle.FixedSingle;
            usernameField.Font = new Font("Segoe UI", 19.8000011F);
            usernameField.Location = new Point(38, 220);
            usernameField.Name = "usernameField";
            usernameField.ReadOnly = true;
            usernameField.Size = new Size(290, 51);
            usernameField.TabIndex = 22;
            // 
            // RoleField
            // 
            RoleField.BackColor = SystemColors.Info;
            RoleField.BorderStyle = BorderStyle.FixedSingle;
            RoleField.Font = new Font("Segoe UI", 19.8000011F);
            RoleField.Location = new Point(38, 312);
            RoleField.Name = "RoleField";
            RoleField.ReadOnly = true;
            RoleField.Size = new Size(290, 51);
            RoleField.TabIndex = 23;
            // 
            // profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 399);
            Controls.Add(RoleField);
            Controls.Add(usernameField);
            Controls.Add(label1);
            Controls.Add(userName);
            Controls.Add(fullName);
            Controls.Add(fnameField);
            Controls.Add(backButton);
            Controls.Add(profileLabel);
            Name = "profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label profileLabel;
        private Button backButton;
        private Label label1;
        private Label userName;
        private Label fullName;
        private TextBox fnameField;
        private TextBox usernameField;
        private TextBox RoleField;
    }
}