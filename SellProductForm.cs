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
        StackDataList dataUpdate;
        public int iD;
        public SellProductForm(int id, StackDataList dataList)
        {
            InitializeComponent();
            iD = id;
            dataUpdate = dataList;
        }

        private void SellProductForm_Load(object sender, EventArgs e)
        {

        }

        private void quantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

            if (quantityNumericUpDown.Value > 0 && dataUpdate.GetSpecificProductById(iD) != null)
            { 
                quantityNumericUpDown.Maximum = dataUpdate.GetSpecificProductById(iD).Quantity ;
            }
            else
            {
                quantityNumericUpDown.Enabled = false;
                return;
            }        
        }

        private void sellButton_Click(object sender, EventArgs e)
        {

            dataUpdate.Update(int.Parse(quantityNumericUpDown.Text), iD);
            if (quantityNumericUpDown.Value <= 0)
            {
                return;
            }
            else if(quantityNumericUpDown.Value > 0 && dataUpdate.GetSpecificProductById(iD) != null) 
            {
                double totalprice = int.Parse(quantityNumericUpDown.Text) * dataUpdate.GetSpecificProductById(iD).TotalPrice();
                Calculatetotalprice.Text = totalprice.ToString();
            }
            
            if (dataUpdate.GetSpecificProductById(iD).Quantity == 0)
            {
                quantityNumericUpDown.Enabled = false;
                dataUpdate.RemovedSpesProduct(iD);
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
