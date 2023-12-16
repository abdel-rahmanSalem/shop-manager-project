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
        public static HomepageForm instance;
        public static HomepageForm Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new HomepageForm();
                }
                return instance;
            }
        }
        public HomepageForm()
        {
            InitializeComponent();
        }

        private void addprodButton_Click(object sender, EventArgs e)
        {
            AddProductForm addform = new AddProductForm();
            this.Hide();
            addform.ShowDialog();
            this.Close();
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            InventoryForm invenform = InventoryForm.Instance;
            this.Hide();
            invenform.ShowDialog();
            this.Close();

        }


        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginForm logout = new LoginForm();
            this.Hide();
            logout.ShowDialog();
            this.Close();
        }
    }
}
