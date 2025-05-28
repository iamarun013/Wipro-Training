using System.Data;
using System.Data.SqlClient;

public void DeleteProduct(int productId)
{
    string connectionString = "your_connection_string_here"; // replace with your actual connection string

    string deleteQuery = "DELETE FROM Products WHERE ProductID = @ProductID";

    using (SqlConnection connection = new SqlConnection(connectionString))
    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
    {
        // Add parameter to prevent SQL injection
        command.Parameters.Add("@ProductID", SqlDbType.Int).Value = productId;

        try
        {
            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                // Deletion successful
                Console.WriteLine("Product deleted successfully.");
            }
            else
            {
                // No product found with that ProductID
                Console.WriteLine("No product found with the specified ProductID.");
            }
        }
        catch (SqlException ex)
        {
            // Handle exception
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}