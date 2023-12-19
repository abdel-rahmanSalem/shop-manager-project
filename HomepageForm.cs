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
    public partial class HomepageForm : Form
    {
        public HomepageForm()
        {
            InitializeComponent();

            // Ensure that the entire application is closed when MyForm is closed
            this.FormClosed += (sender, e) => Application.Exit();
        }

        private void addprodButton_Click(object sender, EventArgs e)
        {
            AddProductForm addform = new AddProductForm();
            addform.ShowDialog();
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            InventoryForm inventory = InventoryForm.Instance;
            this.Hide();
            inventory.Show();
        }


        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginForm logout = new LoginForm();
            this.Hide();
            logout.Show();
        }

        private void stockButton_Click(object sender, EventArgs e)
        {
            StockForm stockForm = StockForm.Instance;
            this.Hide();
            stockForm.Show();

        }


    }
}
