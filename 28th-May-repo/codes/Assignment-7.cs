using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        DisplayTotalSalesByCategory();
    }

    static void DisplayTotalSalesByCategory()
    {
        string connectionString = "Server=.;Database=NorthWind;Trusted_Connection=True;";
        string query = @"
            SELECT CategoryID, SUM(UnitPrice * Quantity) AS TotalSales
            FROM [Order Details]
            GROUP BY CategoryID";

        try
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            using SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            Console.WriteLine("CategoryID | TotalSales");
            Console.WriteLine("------------------------");

            foreach (DataRow row in dt.Rows)
            {
                int categoryId = Convert.ToInt32(row["CategoryID"]);
                decimal totalSales = Convert.ToDecimal(row["TotalSales"]);

                Console.WriteLine($"{categoryId} | {totalSales:C}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}