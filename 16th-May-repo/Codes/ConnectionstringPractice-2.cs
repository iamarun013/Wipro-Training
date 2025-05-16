using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        // Instantiate the connection
        SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=SSPI");
        SqlDataReader rdr = null;

        try
        {
            // Open the connection
            conn.Open();

            // Create the command
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", conn);

            // Execute the command and get a data reader
            rdr = cmd.ExecuteReader();

            // Read and print the data
            while (rdr.Read())
            {
                // Assuming you want to print the CustomerID, which is usually at index 1 or 0
                // Replace rdr[1] with the correct column index or name as needed
                Console.WriteLine(rdr["CustomerID"]);
            }
        }
        catch (Exception ex)
        {
            // Print the exception message
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            // Close the reader if it's open
            if (rdr != null)
            {
                rdr.Close();
            }

            // Close the connection
            if (conn != null)
            {
                conn.Close();
            }
        }

        Console.ReadLine(); // Keep console open
    }
}