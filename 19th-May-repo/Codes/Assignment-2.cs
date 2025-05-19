using System;
using System.Collections.Generic;

// Step 1: Employee class
public class Employee
{
    public int EmployeeID { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public Employee(int employeeID, string name, decimal salary)
    {
        EmployeeID = employeeID;
        Name = name;
        Salary = salary;
    }
}

class Program
{
    static void Main()
    {
        // Step 2: Create a List<Employee> and add employees
        List<Employee> employees = new List<Employee>
        {
            new Employee(101, "Alice", 75000m),
            new Employee(102, "Bob", 85000m),
            new Employee(103, "Charlie", 65000m),
            new Employee(104, "Diana", 95000m),
            new Employee(105, "Ethan", 70000m)
        };

        // 3. Find and display employee with highest salary
        Employee highestPaid = null;
        decimal maxSalary = decimal.MinValue;
        foreach (var emp in employees)
        {
            if (emp.Salary > maxSalary)
            {
                maxSalary = emp.Salary;
                highestPaid = emp;
            }
        }

        Console.WriteLine($"Highest Paid Employee: {highestPaid.Name} with Salary: {highestPaid.Salary:C}");

        // 4. Store EmployeeID and Name in a Dictionary
        Dictionary<int, string> employeeDict = new Dictionary<int, string>();
        foreach (var emp in employees)
        {
            employeeDict[emp.EmployeeID] = emp.Name;
        }

        // 5. Display dictionary contents
        Console.WriteLine("\nEmployee Dictionary (ID -> Name):");
        foreach (var kvp in employeeDict)
        {
            Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
        }

        // 6. Search for an employee by ID
        int searchID = 102; // example ID to search
        if (employeeDict.TryGetValue(searchID, out string employeeName))
        {
            Console.WriteLine($"\nEmployee with ID {searchID} found: {employeeName}");
        }
        else
        {
            Console.WriteLine($"\nEmployee with ID {searchID} not found.");
        }
    }
}