using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. Build the salary lookup table
        Dictionary<int, decimal> employeeSalaries = new Dictionary<int, decimal>
        {
            { 101, 55000.50m },
            { 102, 62000.75m },
            { 103, 48000.00m },
            { 104, 70000.25m },
            { 105, 53000.00m }
        };

        // 3. Ask the user to enter an Employee ID
        Console.Write("Enter Employee ID: ");
        string input = Console.ReadLine();

        // Validate input as integer
        if (int.TryParse(input, out int employeeId))
        {
            // 4. Display salary if found
            if (employeeSalaries.TryGetValue(employeeId, out decimal salary))
            {
                Console.WriteLine($"Salary for Employee ID {employeeId} is: ${salary}");
            }
            else
            {
                Console.WriteLine("Employee ID not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric Employee ID.");
        }
    }
}