using System.Drawing;
using System.Collections.Generic;
using System.Drawing.Drawing2D;



namespace shopManager
{
    public partial class InventoryForm : Form
    {
        StackDataList dataList;
        public InventoryForm()
        {
            InitializeComponent();
            dataList = new StackDataList();
            dataGridView.CellContentClick += dataGridView_CellContentClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set focus to the nameTextBox
            //nameTextBox.Focus();

            // Load existing products into dataGridView
            LoadProductsToDataGridView();

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            //// Validate name
            //string name = nameTextBox.Text.Trim();
            //if (string.IsNullOrEmpty(name))
            //{
            //    MessageBox.Show("Please enter a valid name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //// Validate category
            //string category = categoryComboBox.Text;
            //if (category != "Cameras" && category != "Phones" && category != "Accessories")
            //{
            //    MessageBox.Show("Please select a valid category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //// Validate quantity
            //int quantity;
            //if (!int.TryParse(quantityNumericUpDown.Text, out quantity) || quantity <= 0)
            //{
            //    MessageBox.Show("Please enter a valid quantity more than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //// Validate cost
            //double cost;
            //if (!double.TryParse(costTextBox.Text, out cost) || cost <= 0)
            //{
            //    MessageBox.Show("Please enter a valid cost more than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //// Validate profit
            //double profit;
            //if (!double.TryParse(profitTextBox.Text, out profit) || profit < 0)
            //{
            //    MessageBox.Show("Please enter a valid profit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //// All validations passed,
            //// add the product to the stack
            //dataList.PushNewProduct(name, category, quantity, cost, profit);

            //// Clear the form
            //ClearForm();

            //// set focus to the first input field if needed
            //nameTextBox.Focus();

            // Reload products into dataGridView
            LoadProductsToDataGridView();
        }

        private void ClearForm()
        {
            //nameTextBox.Text = "";
            //categoryComboBox.SelectedIndex = -1; // Reset category selection
            //quantityNumericUpDown.Value = 0;
            //costTextBox.Text = "";
            //profitTextBox.Text = "";
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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs dataGrid)
        {
            if (dataGrid.RowIndex >= 0)
            {
                int columnIndex = dataGrid.ColumnIndex;
                int rowIndex = dataGrid.RowIndex;

                // Check if the "Edit" button is clicked
                if (columnIndex == dataGridView.Columns["Column6"].Index)
                {
                    // Handle edit logic, for example, show a form for editing
                    // You can use the rowIndex to get the corresponding Product from the stack
                    // Update the product in the stack and reload data into the dataGridView
                    // Example:
                    // Product selectedProduct = dataList.GetProductAtIndex(rowIndex);
                    // ShowEditForm(selectedProduct);
                }
                // Check if the "Delete" button is clicked
                else if (columnIndex == dataGridView.Columns["Column7"].Index)
                {
                    string prodId = dataGridView.Rows[rowIndex].Cells[1].Value.ToString();
                    dataList.RemovedSpesProduct(int.Parse(prodId));
                    LoadProductsToDataGridView();
                }
            }
        }

        private const int MinProductId = 1111110;

        private void UpdateDataGridViewWithProduct(Product product)
        {
            // Clear existing data
            dataGridView.Rows.Clear();

            // Update UI with the retrieved product information
            dataGridView.Rows.Add(product.Name, product.ID, product.Category, product.Quantity, product.TotalPrice(), "Edit", "Delete");
        }

        private void search_ById(object sender, EventArgs e)
        {
            string proID = searchTextBox.Text;

            if (int.TryParse(proID, out int id))
            {
                if (id >= MinProductId)
                {
                    Product wantedProd = dataList.GetSpecificProductById(id);

                    if (wantedProd != null)
                    {
                        UpdateDataGridViewWithProduct(wantedProd);
                    }
                    else
                    {
                        MessageBox.Show($"Product with ID {id} not found.", "Product Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid product ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric product ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addProdButton_Click(object sender, EventArgs e)
        {
            AddProductForm addProduct = new AddProductForm();
            addProduct.ShowDialog();
        }
    }

}