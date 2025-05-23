using System;
using System.Xml.Linq;

namespace ConsoleApp1;

class Program
{
    public static void Main()
    {
        //Student student1 = new Student();
        //student1.RollNumber = 101;
        //student1.Name = "Amit";
        //student1.Marks = 85;

        //student1.PrintDetails();

        Student student1 = new Student { RollNumber = 101, Name = "Neha", Marks=90 };
        Student student2 = new Student { RollNumber = 102, Name = "Ravi", Marks = 85 };


        Employee emp1 = new Employee { EmployeeID = 1001, Name = "Arunava", Department = ".NEt Development", Salary = 23000 };
        emp1.PrintDetails();
        emp1.UpdateSalary(emp1.Salary);
        emp1.AnnualSalary(emp1.Salary);


        student1.PrintDetails();
        student2.PrintDetails();
       
        Calculator calculator = new Calculator();
        Console.WriteLine(calculator.Add(1, 2));
        Console.WriteLine(calculator.Add(4.5, 7.2));
        Console.WriteLine(calculator.Add(1, 2, 9));

        Console.WriteLine(calculator.Substract(1, 2));
        Console.WriteLine(calculator.Substract(4.5, 7.2));
        Console.WriteLine(calculator.Substract(1, 2, 9));

        Console.WriteLine(calculator.Mul(1, 2));
        Console.WriteLine(calculator.Mul(4.5, 7.2));
        Console.WriteLine(calculator.Mul(1, 2, 9));

    }
}