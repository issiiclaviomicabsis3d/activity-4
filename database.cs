using System.Data;
using System.Data.OleDb;

public static class Database
{
    private static readonly string DatabasePath = Path.Combine(
        AppContext.BaseDirectory,
        "clavio_Inventory.accdb");

    private static readonly string ConnectionString =
        $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={DatabasePath};Persist Security Info=False;";

    public static OleDbConnection GetConnection()
    {
        return new OleDbConnection(ConnectionString);
    }

    public static void EnsureProductsTable()
    {
        if (!File.Exists(DatabasePath))
        {
            throw new FileNotFoundException(
                $"The Access database was not found at '{DatabasePath}'.",
                DatabasePath);
        }

        using OleDbConnection connection = GetConnection();
        connection.Open();

        DataTable tables = connection.GetSchema("Tables");
        bool tableExists = tables.Rows.Cast<DataRow>().Any(row =>
            string.Equals(row["TABLE_NAME"]?.ToString(), "Products", StringComparison.OrdinalIgnoreCase) &&
            string.Equals(row["TABLE_TYPE"]?.ToString(), "TABLE", StringComparison.OrdinalIgnoreCase));

        if (!tableExists)
        {
            using OleDbCommand createTable = connection.CreateCommand();
            createTable.CommandText = @"
                CREATE TABLE Products
                (
                    ProductId TEXT(50) NOT NULL,
                    ProductName TEXT(150) NOT NULL,
                    Category TEXT(100) NOT NULL,
                    Quantity INTEGER NOT NULL,
                    Price DECIMAL(18, 2) NOT NULL,
                    Status TEXT(50) NOT NULL,
                    CONSTRAINT PK_Products PRIMARY KEY (ProductId)
                )";
            createTable.ExecuteNonQuery();
        }

        DataTable columns = connection.GetSchema("Columns", new[] { null, null, "Products", null });
        string[] requiredColumns = { "ProductId", "ProductName", "Category", "Quantity", "Price", "Status" };
        bool schemaIsValid = requiredColumns.All(requiredColumn => columns.Rows.Cast<DataRow>().Any(row =>
            string.Equals(row["COLUMN_NAME"]?.ToString(), requiredColumn, StringComparison.OrdinalIgnoreCase)));

        if (!schemaIsValid)
        {
            throw new InvalidOperationException(
                "The database schema is invalid. Expected Products with columns " +
                "ProductId, ProductName, Category, Quantity, Price, and Status.");
        }
    }
}