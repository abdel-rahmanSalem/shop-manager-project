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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            loginPanel = new Panel();
            loginButton = new Button();
            passwordLabel = new Label();
            usernameLabel = new Label();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            loginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            loginPanel.BackColor = Color.FromArgb(35, 36, 60);
            loginPanel.Controls.Add(loginButton);
            loginPanel.Controls.Add(passwordLabel);
            loginPanel.Controls.Add(usernameLabel);
            loginPanel.Controls.Add(passwordTextBox);
            loginPanel.Controls.Add(usernameTextBox);
            loginPanel.ForeColor = Color.White;
            loginPanel.Location = new Point(367, 269);
            loginPanel.Margin = new Padding(3, 2, 3, 2);
            loginPanel.MaximumSize = new Size(524, 244);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(524, 244);
            loginPanel.TabIndex = 0;
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginButton.BackColor = Color.FromArgb(35, 36, 60);
            loginButton.Cursor = Cursors.Hand;
            loginButton.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.ForeColor = Color.AliceBlue;
            loginButton.Location = new Point(83, 187);
            loginButton.Margin = new Padding(0);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(350, 39);
            loginButton.TabIndex = 2;
            loginButton.Text = "Log in";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Location = new Point(83, 104);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(68, 15);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "PASSWORD";
            // 
            // usernameLabel
            // 
            usernameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.ForeColor = Color.White;
            usernameLabel.Location = new Point(83, 42);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(68, 15);
            usernameLabel.TabIndex = 11;
            usernameLabel.Text = "USERNAME";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.BackColor = Color.FromArgb(67, 68, 89);
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.ForeColor = Color.AliceBlue;
            passwordTextBox.Location = new Point(83, 124);
            passwordTextBox.Margin = new Padding(3, 2, 3, 2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(350, 29);
            passwordTextBox.TabIndex = 1;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usernameTextBox.BackColor = Color.FromArgb(67, 68, 89);
            usernameTextBox.BorderStyle = BorderStyle.None;
            usernameTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.ForeColor = Color.AliceBlue;
            usernameTextBox.Location = new Point(83, 62);
            usernameTextBox.Margin = new Padding(3, 2, 3, 2);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(350, 29);
            usernameTextBox.TabIndex = 0;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot__54_;
            ClientSize = new Size(1264, 661);
            Controls.Add(loginPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel loginPanel;
        private Button loginButton;
        private Label passwordLabel;
        private Label usernameLabel;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
    }
}