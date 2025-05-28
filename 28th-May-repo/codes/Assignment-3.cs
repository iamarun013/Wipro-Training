using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString = "Server=.;Database=NorthWind;Trusted_Connection=True;";

        string insertQuery = @"
            INSERT INTO Products (ProductName, SupplierID, CategoryID, UnitPrice)
            VALUES (@ProductName, @SupplierID, @CategoryID, @UnitPrice)";

        try
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            using SqlCommand command = new SqlCommand(insertQuery, connection);

            // Add parameters with values
            command.Parameters.AddWithValue("@ProductName", "Test Product");
            command.Parameters.AddWithValue("@SupplierID", 1);
            command.Parameters.AddWithValue("@CategoryID", 1);
            command.Parameters.AddWithValue("@UnitPrice", 25);

            connection.Open();

            int rowsAffected = command.ExecuteNonQuery();

            Console.WriteLine($"{rowsAffected} row(s) inserted successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}