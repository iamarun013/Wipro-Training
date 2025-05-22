using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
}

class Program
{
    static void Main()
    {
        // 2. Adding 6 employees across 2-3 departments
        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Alice", Department = "HR" },
            new Employee { Name = "Bob", Department = "IT" },
            new Employee { Name = "Charlie", Department = "HR" },
            new Employee { Name = "Diana", Department = "Finance" },
            new Employee { Name = "Ethan", Department = "IT" },
            new Employee { Name = "Fiona", Department = "Finance" }
        };

        // 3. Using LINQ to group employees by department
        var groupedEmployees = employees
            .GroupBy(e => e.Department);

        // 4. Printing employees under each department
        foreach (var group in groupedEmployees)
        {
            Console.WriteLine($"Department: {group.Key}");
            foreach (var employee in group)
            {
                Console.WriteLine($" - {employee.Name}");
            }
            Console.WriteLine(); // Adding an empty line for better readability
        }
    }
}