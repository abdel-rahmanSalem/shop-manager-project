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
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text != "admin" || passwordTextBox.Text != "1324")
                MessageBox.Show("Wrong Username Or Password.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                InventoryForm inventory = new InventoryForm();
                this.Hide();
                inventory.ShowDialog();
                this.Close();
            }
        }
    }
}
