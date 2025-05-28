using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string customerId = "ALFKI"; // Replace with desired CustomerID
        CallCustOrderHist(customerId);
    }

    static void CallCustOrderHist(string customerId)
    {
        string connectionString = "Server=.;Database=NorthWind;Trusted_Connection=True;";

        try
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            using SqlCommand cmd = new SqlCommand("CustOrderHist", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            // Add parameter for CustomerID
            cmd.Parameters.AddWithValue("@CustomerID", customerId);

            connection.Open();

            using SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine($"Order History for CustomerID: {customerId}");
            Console.WriteLine("ProductName | Total");
            Console.WriteLine("---------------------");

            while (reader.Read())
            {
                string productName = reader["ProductName"].ToString();
                int total = Convert.ToInt32(reader["Total"]);

                Console.WriteLine($"{productName} | {total}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}