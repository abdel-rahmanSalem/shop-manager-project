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
    public partial class SellProductForm : Form
    {
        InventoryForm inventoryForm = InventoryForm.Instance;
        StockForm stockForm = StockForm.Instance;

        public int iD;

        public SellProductForm(int id)
        {
            InitializeComponent();
            iD = 1111110;
        }

        private void SellProductForm_Load(object sender, EventArgs e)
        {

        }

        private void quantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

            if (quantityNumericUpDown.Value > 0 && InventoryForm.dataList.GetSpecificProductById(iD) != null)
            {
                quantityNumericUpDown.Maximum = InventoryForm.dataList.GetSpecificProductById(iD).Quantity;
            }
            else
            {
                quantityNumericUpDown.Enabled = false;
                return;
            }
        }

        private void sellButton_Click(object sender, EventArgs e)
        {

            InventoryForm.dataList.Update(int.Parse(quantityNumericUpDown.Text), iD);
            if (quantityNumericUpDown.Value <= 0)
            {
                return;
            }
            else if (quantityNumericUpDown.Value > 0 && InventoryForm.dataList.GetSpecificProductById(iD) != null)
            {
                double totalprice = int.Parse(quantityNumericUpDown.Text) * InventoryForm.dataList.GetSpecificProductById(iD).TotalPrice();
                Calculatetotalprice.Text = totalprice.ToString();
                stockForm.addOrder(InventoryForm.dataList.GetSpecificProductById(iD).Name, int.Parse(quantityNumericUpDown.Text),totalprice);
            }

            if (InventoryForm.dataList.GetSpecificProductById(iD).Quantity == 0)
            {
                quantityNumericUpDown.Enabled = false;
                InventoryForm.dataList.RemovedSpesProduct(iD);
            }
            quantityNumericUpDown.Value = 0;
            inventoryForm.LoadProductsToDataGridView();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
