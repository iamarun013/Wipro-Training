using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter EmployeeID:");
        int employeeId = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter new Title:");
        string newTitle = Console.ReadLine();

        UpdateEmployeeTitle(employeeId, newTitle);
    }

    static void UpdateEmployeeTitle(int employeeId, string newTitle)
    {
        string connectionString = "Server=.;Database=NorthWind;Trusted_Connection=True;";
        string updateQuery = @"
            UPDATE Employees
            SET Title = @Title
            WHERE EmployeeID = @EmployeeID";

        try
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            using SqlCommand command = new SqlCommand(updateQuery, connection);

            // Bind parameters
            command.Parameters.AddWithValue("@Title", newTitle);
            command.Parameters.AddWithValue("@EmployeeID", employeeId);

            connection.Open();

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                Console.WriteLine("Employee title updated successfully.");
            }
            else
            {
                Console.WriteLine("No employee found with the specified EmployeeID.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}