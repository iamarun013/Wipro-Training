using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        // Instantiate the connection
        using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=SSPI"))
        {
            SqlDataReader rdr = null;

            try
            {
                // Open the connection
                conn.Open();

                // Create the command
                using (SqlCommand cmd = new SqlCommand("SELECT ContactName, City, CompanyName FROM Customers", conn))
                {
                    // Execute the command and get a data reader
                    using (rdr = cmd.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            Console.WriteLine("Contact Name\tCity\tCompany Name");
                            Console.WriteLine("---------------------------------"); // separator

                            while (rdr.Read())
                            {
                                // Retrieve values
                                string contactName = rdr["ContactName"] as string ?? "N/A";
                                string city = rdr["City"] as string ?? "N/A";
                                string companyName = rdr["CompanyName"] as string ?? "N/A";

                                Console.WriteLine($"{contactName}\t{city}\t{companyName}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No data found");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}