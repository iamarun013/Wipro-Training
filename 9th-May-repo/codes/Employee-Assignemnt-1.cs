using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        public int EmployeeID;
        public string Name;
        public string Department;
        public int Salary;

        public void PrintDetails()
        {
            Console.WriteLine($"EmployeeID: {EmployeeID} , Name: {Name}, Department: {Department}, Salary: {Salary}");

        }

        public int UpdateSalary(int salary)
        {
            Random rand = new Random();
            salary = rand.Next(20000, 50000);
            return salary;
        }
        public void AnnualSalary(int salary)
        {
            Console.WriteLine("Annual salary: ");
            Console.WriteLine(salary * 12);
        }
    }
}
