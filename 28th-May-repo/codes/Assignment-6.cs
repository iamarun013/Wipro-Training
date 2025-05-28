using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        DisplayOrdersWithCustomerNames();
    }

    static void DisplayOrdersWithCustomerNames()
    {
        string connectionString = "Server=.;Database=NorthWind;Trusted_Connection=True;";
        string query = @"
            SELECT o.OrderID, c.CompanyName, o.OrderDate
            FROM Orders o
            INNER JOIN Customers c ON o.CustomerID = c.CustomerID";

        try
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            using SqlCommand command = new SqlCommand(query, connection);
            
            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();

            Console.WriteLine("OrderID | CompanyName | OrderDate");
            Console.WriteLine("--------------------------------------");

            while (reader.Read())
            {
                int orderId = reader.GetInt32(0);
                string companyName = reader["CompanyName"].ToString();
                DateTime orderDate = reader.GetDateTime(2);

                Console.WriteLine($"{orderId} | {companyName} | {orderDate.ToShortDateString()}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}