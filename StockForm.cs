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
    public partial class StockForm : Form
    {
        private static StockForm instance;

        public static StockForm Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new StockForm();
                }
                return instance;
            }
        }
        public void addOrder(string name, int quantity, double price)
        {
            dataGridView1.Rows.Add(name, quantity, price);
        }

        public StockForm()
        {
            InitializeComponent();

            // Ensure that the entire application is closed when MyForm is closed
            this.FormClosed += (sender, e) => Application.Exit();
        }

        private void StockForm_Load(object sender, EventArgs e)
        {

        }

        private void checkOutBtn_Click(object sender, EventArgs e)
        {
           checkForm f = new checkForm();
            this.Hide();
            f.Show();
            
            dataGridView1.Rows.Clear();
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            SellProductForm sellProduct = new SellProductForm(0, 'C');
            sellProduct.ShowDialog();
        }

        private void home3buttnPage_Click(object sender, EventArgs e)
        {
            HomepageForm home = new HomepageForm();
            this.Hide();
            home.Show();
        }

        private void StockForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
