namespace StoreInventoryPos
{
    partial class profile
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            profileLabel = new Label();
            backButton = new Button();
            lblFullName = new Label();
            lblUsername = new Label();
            lblRole = new Label();
            txtFullName = new TextBox();
            txtUsername = new TextBox();
            txtRole = new TextBox();

            SuspendLayout();

            // profileLabel
            profileLabel.AutoSize = true;
            profileLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            profileLabel.Location = new Point(30, 20);
            profileLabel.Name = "profileLabel";
            profileLabel.Size = new Size(130, 32);
            profileLabel.Text = "My Profile";

            // backButton
            backButton.Text = "Back";
            backButton.Location = new Point(350, 20);
            backButton.Size = new Size(75, 32);
            backButton.Click += backButton_Click;

            // lblFullName
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(30, 80);
            lblFullName.Text = "Full Name";

            // txtFullName
            txtFullName.Location = new Point(120, 75);
            txtFullName.Size = new Size(200, 25);
            txtFullName.ReadOnly = true;
            txtFullName.BackColor = SystemColors.ControlLight;

            // lblUsername
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(30, 120);
            lblUsername.Text = "Username";

            // txtUsername
            txtUsername.Location = new Point(120, 115);
            txtUsername.Size = new Size(200, 25);
            txtUsername.ReadOnly = true;
            txtUsername.BackColor = SystemColors.ControlLight;

            // lblRole
            lblRole.AutoSize = true;
            lblRole.Location = new Point(30, 160);
            lblRole.Text = "Role";

            // txtRole
            txtRole.Location = new Point(120, 155);
            txtRole.Size = new Size(200, 25);
            txtRole.ReadOnly = true;
            txtRole.BackColor = SystemColors.ControlLight;

            // profile form
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 220);
            Controls.Add(profileLabel);
            Controls.Add(backButton);
            Controls.Add(lblFullName);
            Controls.Add(txtFullName);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblRole);
            Controls.Add(txtRole);
            Name = "profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label profileLabel;
        private Button backButton;
        private Label lblFullName;
        private Label lblUsername;
        private Label lblRole;
        private TextBox txtFullName;
        private TextBox txtUsername;
        private TextBox txtRole;
    }
}
