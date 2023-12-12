namespace shopManager
{
    partial class LoginForm
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
            panel1 = new Panel();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            usernameLabel = new Label();
            passwordLabel = new Label();
            loginButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(35, 36, 60);
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(passwordLabel);
            panel1.Controls.Add(usernameLabel);
            panel1.Controls.Add(passwordTextBox);
            panel1.Controls.Add(usernameTextBox);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(164, 128);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 284);
            panel1.TabIndex = 0;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.FromArgb(67, 68, 89);
            usernameTextBox.BorderStyle = BorderStyle.None;
            usernameTextBox.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(48, 79);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(359, 32);
            usernameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.FromArgb(67, 68, 89);
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(52, 143);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(355, 36);
            passwordTextBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.ForeColor = Color.FromArgb(67, 68, 89);
            usernameLabel.Location = new Point(61, 56);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(86, 20);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "USERNAME";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.ForeColor = Color.FromArgb(67, 68, 89);
            passwordLabel.Location = new Point(61, 120);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(87, 20);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "PASSWORD";
            // 
            // loginButton
            // 
            loginButton.ForeColor = Color.Black;
            loginButton.Location = new Point(191, 201);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(94, 29);
            loginButton.TabIndex = 4;
            loginButton.Text = "Log in";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot__54_;
            ClientSize = new Size(800, 553);
            Controls.Add(panel1);
            MinimumSize = new Size(800, 600);
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button loginButton;
        private Label passwordLabel;
        private Label usernameLabel;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
    }
}