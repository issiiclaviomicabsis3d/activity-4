using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CLAVIOMICA_INVENTORY
{
    public partial class Product : UserControl
    {
        public Product()
        {
            InitializeComponent();
            comboBox3.Items.AddRange(new[] { "Food", "Non-Food" });
            comboBox1.Items.AddRange(new[] { "In Stock", "Low Stock", "Out of Stock" });
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            LoadProducts();
        }

        private void dataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is not DataRowView row)
            {
                return;
            }

            textBox1.Text = row["ProductId"]?.ToString() ?? string.Empty;
            textBox2.Text = row["ProductName"]?.ToString() ?? string.Empty;
            comboBox3.Text = row["Category"]?.ToString() ?? string.Empty;
            textBox3.Text = row["Quantity"]?.ToString() ?? string.Empty;
            textBox4.Text = row["Price"]?.ToString() ?? string.Empty;
            comboBox1.Text = row["Status"]?.ToString() ?? string.Empty;
        }

        private void lblCategoriesCaption_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (!TryReadProduct(out ProductData product, requireId: false))
            {
                return;
            }

            try
            {
                Database.EnsureProductsTable();
                using OleDbConnection connection = Database.GetConnection();
                connection.Open();
                using OleDbTransaction transaction = connection.BeginTransaction();
                using OleDbCommand nextIdCommand = connection.CreateCommand();
                nextIdCommand.Transaction = transaction;
                nextIdCommand.CommandText = "SELECT IIf(IsNull(MAX(Val(ProductId))), 0, MAX(Val(ProductId))) + 1 FROM Products";
                string productId = Convert.ToString(nextIdCommand.ExecuteScalar()) ?? "1";

                using OleDbCommand command = connection.CreateCommand();
                command.Transaction = transaction;
                command.CommandText = @"INSERT INTO Products
                    (ProductId, ProductName, Category, Quantity, Price, Status)
                    VALUES (?, ?, ?, ?, ?, ?)";
                AddParameters(command, product with { Id = productId });
                int rowsInserted = command.ExecuteNonQuery();
                transaction.Commit();
                if (rowsInserted != 1)
                {
                    MessageBox.Show("The product was not added.", "Products", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                RefreshProductsGrid(productId);
                MessageBox.Show("Product added successfully.", "Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearProductTextBoxes();
            }
            catch (OleDbException ex)
            {
                ShowDatabaseError(ex);
            }
            catch (InvalidOperationException ex)
            {
                ShowDatabaseError(ex);
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (!TryReadProduct(out ProductData product))
            {
                return;
            }

            try
            {
                Database.EnsureProductsTable();
                using OleDbConnection connection = Database.GetConnection();
                connection.Open();
                using OleDbCommand command = connection.CreateCommand();
                command.CommandText = @"UPDATE Products SET ProductName = ?,
                    Category = ?, Quantity = ?, Price = ?, Status = ?
                    WHERE ProductId = ?";
                AddUpdateParameters(command, product);
                if (command.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("No product with that ID was found.", "Products", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Product updated successfully.", "Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProducts();
            }
            catch (OleDbException ex)
            {
                ShowDatabaseError(ex);
            }
            catch (InvalidOperationException ex)
            {
                ShowDatabaseError(ex);
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string productId = textBox1.Text.Trim();
            if (productId.Length == 0)
            {
                MessageBox.Show("Select or enter a product ID first.", "Products", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Database.EnsureProductsTable();
                using OleDbConnection connection = Database.GetConnection();
                connection.Open();
                using OleDbCommand command = connection.CreateCommand();
                command.CommandText = "DELETE FROM Products WHERE ProductId = ?";
                command.Parameters.Add("@id", OleDbType.VarWChar, 50).Value = productId;
                if (command.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("No product with that ID was found.", "Products", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                LoadProducts();
                ClearFields();
            }
            catch (OleDbException ex)
            {
                ShowDatabaseError(ex);
            }
            catch (InvalidOperationException ex)
            {
                ShowDatabaseError(ex);
            }
        }

        private void LoadProducts()
        {
            try
            {
                Database.EnsureProductsTable();
                using OleDbConnection connection = Database.GetConnection();
                connection.Open();
                using OleDbDataAdapter adapter = new(
                    "SELECT ProductId, ProductName, Category, Quantity, Price, Status FROM Products ORDER BY Val(ProductId), ProductId",
                    connection);
                DataTable products = new();
                adapter.Fill(products);
                UpdateProductSummary(products);
                ConfigureGridColumns();
                dataGridView1.DataSource = products;
            }
            catch (OleDbException ex)
            {
                ShowDatabaseError(ex);
            }
            catch (InvalidOperationException ex)
            {
                ShowDatabaseError(ex);
            }
        }

        private void UpdateProductSummary(DataTable products)
        {
            int totalProducts = products.Rows.Count;
            int inStock = products.AsEnumerable().Count(row =>
                string.Equals(row.Field<string>("Status"), "In Stock", StringComparison.OrdinalIgnoreCase));
            int lowStock = products.AsEnumerable().Count(row =>
                string.Equals(row.Field<string>("Status"), "Low Stock", StringComparison.OrdinalIgnoreCase));
            int outOfStock = products.AsEnumerable().Count(row =>
                string.Equals(row.Field<string>("Status"), "Out of Stock", StringComparison.OrdinalIgnoreCase));

            lblProductsValue.Text = totalProducts.ToString();
            lblLowStockValue.Text = inStock.ToString();
            lblCategoriesValue.Text = lowStock.ToString();
            label1.Text = outOfStock.ToString();
        }

        private void RefreshProductsGrid(string productIdToSelect)
        {
            LoadProducts();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[Column12.Index].Value?.ToString() == productIdToSelect)
                {
                    row.Selected = true;
                    dataGridView1.CurrentCell = row.Cells[Column12.Index];
                    dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        private void ConfigureGridColumns()
        {
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Margin = Padding.Empty;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoGenerateColumns = false;

            SetGridColumn(Column12, "ProductId", "Product ID");
            SetGridColumn(Column2, "ProductName", "Product Name");
            SetGridColumn(Column3, "Category", "Category");
            SetGridColumn(Column4, "Quantity", "Quantity");
            SetGridColumn(Column5, "Price", "Price");
            SetGridColumn(Column6, "Status", "Status");

            Column12.FillWeight = 12;
            Column2.FillWeight = 28;
            Column3.FillWeight = 18;
            Column4.FillWeight = 12;
            Column5.FillWeight = 15;
            Column6.FillWeight = 15;
        }

        private static void SetGridColumn(DataGridViewColumn column, string propertyName, string headerText)
        {
            column.DataPropertyName = propertyName;
            column.HeaderText = headerText;
            column.Visible = true;
        }

        private bool TryReadProduct(out ProductData product, bool requireId = true)
        {
            product = new ProductData();
            if ((requireId && string.IsNullOrWhiteSpace(textBox1.Text)) || string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(comboBox3.Text) || string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Complete all product fields.", "Products", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(textBox3.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Quantity must be a non-negative whole number.", "Products", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(textBox4.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Price must be a non-negative number.", "Products", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            product = new ProductData(textBox1.Text.Trim(), textBox2.Text.Trim(), comboBox3.Text.Trim(), quantity, price, comboBox1.Text.Trim());
            return true;
        }

        private static void AddParameters(OleDbCommand command, ProductData product)
        {
            command.Parameters.Add("@id", OleDbType.VarWChar, 50).Value = product.Id;
            command.Parameters.Add("@name", OleDbType.VarWChar, 150).Value = product.Name;
            command.Parameters.Add("@category", OleDbType.VarWChar, 100).Value = product.Category;
            command.Parameters.Add("@quantity", OleDbType.Integer).Value = product.Quantity;
            command.Parameters.Add("@price", OleDbType.Decimal).Value = product.Price;
            command.Parameters["@price"].Precision = 18;
            command.Parameters["@price"].Scale = 2;
            command.Parameters.Add("@status", OleDbType.VarWChar, 50).Value = product.Status;
        }

        private static void AddUpdateParameters(OleDbCommand command, ProductData product)
        {
            command.Parameters.Add("@name", OleDbType.VarWChar, 150).Value = product.Name;
            command.Parameters.Add("@category", OleDbType.VarWChar, 100).Value = product.Category;
            command.Parameters.Add("@quantity", OleDbType.Integer).Value = product.Quantity;
            OleDbParameter price = command.Parameters.Add("@price", OleDbType.Decimal);
            price.Precision = 18;
            price.Scale = 2;
            price.Value = product.Price;
            command.Parameters.Add("@status", OleDbType.VarWChar, 50).Value = product.Status;
            command.Parameters.Add("@id", OleDbType.VarWChar, 50).Value = product.Id;
        }

        private void ClearFields()
        {
            ClearProductTextBoxes();
            comboBox3.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
        }

        private void ClearProductTextBoxes()
        {
            foreach (TextBox textBox in new[] { textBox1, textBox2, textBox3, textBox4 })
            {
                textBox.Clear();
            }
        }

        private void ShowDatabaseError(Exception ex)
        {
            MessageBox.Show($"Database operation failed: {ex.Message}", "Products", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private sealed record ProductData(string Id, string Name, string Category, int Quantity, decimal Price, string Status)
        {
            public ProductData() : this(string.Empty, string.Empty, string.Empty, 0, 0, string.Empty) { }
        }
    }
}
