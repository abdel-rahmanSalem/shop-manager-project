using System.Drawing;
using System.Collections.Generic;
using System.Drawing.Drawing2D;



namespace shopManager
{
    public partial class Form1 : Form
    {
        StackDataList dataList;
        public Form1()
        {
            InitializeComponent();
            dataList = new StackDataList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set focus to the nameTextBox
            nameTextBox.Focus();

            // Load existing products into dataGridView
            LoadProductsToDataGridView();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            // Validate name
            string name = nameTextBox.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a valid name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate category
            string category = categoryComboBox.Text;
            if (string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Please select a valid category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate quantity
            int quantity;
            if (!int.TryParse(quantityNumericUpDown.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity more than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate cost
            double cost;
            if (!double.TryParse(coatTextBox.Text, out cost) || cost <= 0)
            {
                MessageBox.Show("Please enter a valid cost more than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate profit
            double profit;
            if (!double.TryParse(profitTextBox.Text, out profit) || profit < 0)
            {
                MessageBox.Show("Please enter a valid profit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // All validations passed,
            // add the product to the stack
            dataList.PushNewProduct(name, category, quantity, cost, profit);

            // Clear the form
            ClearForm();

            // set focus to the first input field if needed
            nameTextBox.Focus();

            // Reload products into dataGridView
            LoadProductsToDataGridView();
        }

        private void ClearForm()
        {
            nameTextBox.Text = "";
            categoryComboBox.SelectedIndex = -1; // Reset category selection
            quantityNumericUpDown.Value = 0;
            coatTextBox.Text = "";
            profitTextBox.Text = "";
        }

        private void LoadProductsToDataGridView()
        {
            // Clear existing data
            dataGridView.Rows.Clear();

            // Get all products from the stack
            List<Product> products = dataList.GetAllProducts();

            // Populate dataGridView with product data
            foreach (Product product in products)
            {
                dataGridView.Rows.Add(product.Name, product.ID, product.Category, product.Quantity, product.TotalPrice(), "Edit", "Delete");
            }
        }
    }
}