using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            // Ensure that the entire application is closed when MyForm is closed
            this.FormClosed += (sender, e) => Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text != "admin")
                MessageBox.Show("Wrong Username.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (passwordTextBox.Text != "1324")
                MessageBox.Show("Wrong Password.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                HomepageForm home = new HomepageForm();
                this.Hide();
                home.Show();
            }
        }
    }
}
