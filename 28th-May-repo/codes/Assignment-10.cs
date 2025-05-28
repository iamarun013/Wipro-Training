using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        LoadProductsWithStockGreaterThan20();
    }

    static void LoadProductsWithStockGreaterThan20()
    {
        string connectionString = "Server=.;Database=NorthWind;Trusted_Connection=True;";
        string query = "SELECT * FROM Products WHERE UnitsInStock > 20";

        try
        {
            // Create a connection
            using SqlConnection connection = new SqlConnection(connectionString);
            // Create a data adapter with the query and connection
            using SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            // Create a DataSet
            DataSet ds = new DataSet();

            // Fill the DataSet with the query result
            adapter.Fill(ds, "FilteredProducts");

            // Access the DataTable
            DataTable productsTable = ds.Tables["FilteredProducts"];

            // Display the results
            Console.WriteLine("Products with UnitsInStock > 20:");
            foreach (DataRow row in productsTable.Rows)
            {
                Console.WriteLine($"ProductID: {row["ProductID"]}, ProductName: {row["ProductName"]}, UnitsInStock: {row["UnitsInStock"]}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}