using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopManager
{
    public partial class SellProductForm : Form
    {
        InventoryForm inventoryForm = InventoryForm.Instance;
        StockForm stockForm = StockForm.Instance;

        private int iD;
        public SellProductForm(int id, char flag)
        {
            InitializeComponent();
            if (flag == 'S')
            {
                iD = id;
            }
            else
            {
                sellIdLapel.Visible = true;
                sellIdTextBox.Visible = true;
            }
        }

        private void SellProductForm_Load(object sender, EventArgs e)
        {
        }

        private void sellIdTextBox_TextChanged(object sender, EventArgs e)
        {
            iD = int.Parse(sellIdTextBox.Text);
        }

        private void quantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

            if (quantityNumericUpDown.Value >= 0 && InventoryForm.dataList.GetSpecificProductById(iD) != null)
            {
                quantityNumericUpDown.Maximum = InventoryForm.dataList.GetSpecificProductById(iD).Quantity;
            }
            else
            {
                quantityNumericUpDown.Enabled = false;
                return;
            }
            Calculatetotalprice.Visible = true;
            if (quantityNumericUpDown.Value <= 0)
            {
                return;
            }

            int enteredQuantity = (int)quantityNumericUpDown.Value;

            if (enteredQuantity > 0)
            {
                double totalprice = enteredQuantity * InventoryForm.dataList.GetSpecificProductById(iD).TotalPrice();
                Calculatetotalprice.Text = totalprice.ToString();
            }
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            InventoryForm.dataList.Update(int.Parse(quantityNumericUpDown.Text), iD);
            if (quantityNumericUpDown.Value <= 0)
            {
                MessageBox.Show("Please enter a valid quantity more than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (quantityNumericUpDown.Value > 0 && InventoryForm.dataList.GetSpecificProductById(iD) != null)
            {
                double totalprice = (int)quantityNumericUpDown.Value * InventoryForm.dataList.GetSpecificProductById(iD).TotalPrice();
                stockForm.addOrder(InventoryForm.dataList.GetSpecificProductById(iD).Name, int.Parse(quantityNumericUpDown.Text), totalprice);
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
