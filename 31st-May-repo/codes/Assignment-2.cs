using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeDirectoryWithLINQ
{
    // Define Employee class
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of employees
            List<Employee> employees = new List<Employee>
            {
                new Employee { ID = 1, Name = "Alice", Department = "HR", Salary = 60000 },
                new Employee { ID = 2, Name = "Bob", Department = "IT", Salary = 75000 },
                new Employee { ID = 3, Name = "Charlie", Department = "Finance", Salary = 65000 },
                new Employee { ID = 4, Name = "David", Department = "IT", Salary = 80000 },
                new Employee { ID = 5, Name = "Eva", Department = "HR", Salary = 62000 },
                new Employee { ID = 6, Name = "Frank", Department = "Finance", Salary = 70000 },
                new Employee { ID = 7, Name = "Grace", Department = "IT", Salary = 72000 }
            };

            // 1. Filter employees by a specific department, e.g., "IT"
            string departmentToFilter = "IT";
            var filteredEmployees = employees
                .Where(e => e.Department == departmentToFilter)
                .ToList();

            Console.WriteLine($"Employees in {departmentToFilter} Department:");
            foreach (var emp in filteredEmployees)
            {
                Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Salary: {emp.Salary}");
            }
            Console.WriteLine();

            // 2. Sort employees by salary descending
            var sortedEmployees = employees
                .OrderByDescending(e => e.Salary)
                .ToList();

            Console.WriteLine("Employees sorted by salary (descending):");
            foreach (var emp in sortedEmployees)
            {
                Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary}");
            }
            Console.WriteLine();

            // 3. Find average salary per department
            var avgSalaryPerDept = employees
                .GroupBy(e => e.Department)
                .Select(g => new
                {
                    Department = g.Key,
                    AverageSalary = g.Average(e => e.Salary)
                });

            Console.WriteLine("Average salary per department:");
            foreach (var dept in avgSalaryPerDept)
            {
                Console.WriteLine($"{dept.Department}: {dept.AverageSalary:C}");
            }
        }
    }
}