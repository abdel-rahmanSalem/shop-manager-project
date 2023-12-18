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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LoadSellProductsToDataGridView()
        {
            // Clear existing data
            dataGridView1.Rows.Clear();

            // Get all products from the stack
            dataGridView1.Rows.Add();




        }

        private void StockForm_Load(object sender, EventArgs e)
        {

        }
    }
}
