using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        // Connection string to your database
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=SSPI";

        // Instantiate the connection
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            SqlDataReader rdr = null;

            try
            {
                // Open the connection
                conn.Open();

                // Create the command with the correct JOIN query
                string query = @"
                    SELECT 
                        Employees.FirstName, 
                        Employees.LastName, 
                        Employees.City,
                        EmployeeTerritories.TerritoryID,
                        Territories.TerritoryDescription
                    FROM Employees
                    INNER JOIN EmployeeTerritories ON Employees.EmployeeID = EmployeeTerritories.EmployeeID
                    INNER JOIN Territories ON EmployeeTerritories.TerritoryID = Territories.TerritoryID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Execute and read the data
                    using (rdr = cmd.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            Console.WriteLine("FirstName\tLastName\tCity\tTerritoryID\tTerritoryDescription");
                            Console.WriteLine("--------------------------------------------------------------");

                            while (rdr.Read())
                            {
                                string firstName = rdr["FirstName"] as string ?? "N/A";
                                string lastName = rdr["LastName"] as string ?? "N/A";
                                string city = rdr["City"] as string ?? "N/A";
                                string territoryID = rdr["TerritoryID"] as string ?? "N/A";
                                string territoryDesc = rdr["TerritoryDescription"] as string ?? "N/A";

                                Console.WriteLine($"{firstName}\t{lastName}\t{city}\t{territoryID}\t{territoryDesc}");
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
                Console.WriteLine($"SQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}