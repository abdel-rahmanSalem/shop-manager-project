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
    public partial class addForm : Form
    {
        public addForm()
        {
            InitializeComponent();
        }

        private void addFormButton_Click(object sender, EventArgs e)
        {

            //Validate name
            string name = nameTextBox.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a valid name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Validate category
            string category = categoryBox.Text;
            if (category != "Cameras" && category != "Phones" && category != "Accessories")
            {
                MessageBox.Show("Please select a valid category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Validate quantity
            int quantity;
            if (!int.TryParse(numericUpDown.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity more than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Validate cost
            double cost;
            if (!double.TryParse(costTextBox.Text, out cost) || cost <= 0)
            {
                MessageBox.Show("Please enter a valid cost more than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Validate profit
            double profit;
            if (!double.TryParse(profitTextBox.Text, out profit) || profit < 0)
            {
                MessageBox.Show("Please enter a valid profit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //All validations passed,
            //add the product to the stack
            Form1.DataList.PushNewProduct(name, category, quantity, cost, profit);

            //Clear the form
            ClearForm();

            //set focus to the first input field if needed
            nameTextBox.Focus();
        }

        private void ClearForm()
        {
            nameTextBox.Text = "";
            categoryBox.SelectedIndex = -1; // Reset category selection
            numericUpDown.Value = 0;
            costTextBox.Text = "";
            profitTextBox.Text = "";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 inven = new Form1();
            this.Hide();
            inven.ShowDialog();
            this.Close();
        }
    }
}
