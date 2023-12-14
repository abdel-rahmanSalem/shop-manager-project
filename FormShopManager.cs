using System.Drawing;
using System.Collections.Generic;
using System.Drawing.Drawing2D;



namespace shopManager
{
    public partial class Form1 : Form
    {
        private static StackDataList dataList = new StackDataList();
        public static StackDataList DataList
        {
            get { return dataList; }
        }
        public Form1()
        {
            InitializeComponent();
            dataGridView.CellContentClick += dataGridView_CellContentClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load existing products into dataGridView
            LoadProductsToDataGridView();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            Form addForm = new addForm();
            this.Hide();
            addForm.ShowDialog();
            this.Close();            

            // Reload products into dataGridView
            LoadProductsToDataGridView();
        }

        private void LoadProductsToDataGridView()
        {
            // Clear existing data
            dataGridView.Rows.Clear();

            // Get all products from the stack
            List<Product> products = DataList.GetAllProducts();

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
                    DataList.RemovedSpesProduct(int.Parse(prodId));
                    LoadProductsToDataGridView();
                }
            }
        }

    }

}