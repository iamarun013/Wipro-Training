using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        // Example usage:
        Console.WriteLine("Enter Customer ID to search orders:");
        string customerId = Console.ReadLine();

        GetOrdersByCustomer(customerId);
    }

    static void GetOrdersByCustomer(string customerId)
    {
        string connectionString = "Server=.;Database=NorthWind;Trusted_Connection=True;";
        string query = @"
            SELECT OrderID, OrderDate, ShipAddress 
            FROM Orders 
            WHERE CustomerID = @CustomerID";

        try
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            using SqlCommand command = new SqlCommand(query, connection);

            // Add parameter to prevent SQL injection
            command.Parameters.AddWithValue("@CustomerID", customerId);

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            Console.WriteLine($"Orders for Customer ID: {customerId}");
            Console.WriteLine("OrderID | OrderDate | ShipAddress");
            Console.WriteLine("-----------------------------------");

            bool hasRows = false;

            while (reader.Read())
            {
                hasRows = true;
                int orderId = reader.GetInt32(0);
                DateTime orderDate = reader.GetDateTime(1);
                string shipAddress = reader["ShipAddress"]?.ToString();

                Console.WriteLine($"{orderId} | {orderDate.ToShortDateString()} | {shipAddress}");
            }

            if (!hasRows)
            {
                Console.WriteLine("No orders found for this customer.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}