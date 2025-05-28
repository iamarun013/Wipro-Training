using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString = "Server=.;Database=NorthWind;Trusted_Connection=True;";
        string query = "SELECT CustomerID, CompanyName, Country FROM Customers";

        try
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            using SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();
            Console.WriteLine("CustomerID  |  CompanyName  | Country");
            Console.WriteLine("--------------------------------------");

            while (reader.Read())
            {
                // Access columns by name:
                var customerId = reader["CustomerID"].ToString();
                var companyName = reader["CompanyName"].ToString();
                var country = reader["Country"].ToString();

                Console.WriteLine($"{customerId} | {companyName} | {country}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}