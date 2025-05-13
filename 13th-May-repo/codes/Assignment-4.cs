using System;

abstract class Employee
{
    public abstract void CalculateSalary();

    public void ShowBasicInfo(string employeeType, string name)
    {
        Console.WriteLine($"EMPLOYEE DETAILS: {employeeType}, {name}");
    }
}

class FullTimeEmployee : Employee
{
    private double basic;
    private double allowance;

    public FullTimeEmployee(double basic, double allowance)
    {
        this.basic = basic;
        this.allowance = allowance;
    }

    public override void CalculateSalary()
    {
        double salary = basic + allowance;
        Console.WriteLine($"Salary: {salary}");
    }
}

class PartTimeEmployee : Employee
{
    private double hourlyRate;
    private double hoursWorked;

    public PartTimeEmployee(double hourlyRate, double hoursWorked)
    {
        this.hourlyRate = hourlyRate;
        this.hoursWorked = hoursWorked;
    }

    public override void CalculateSalary()
    {
        double salary = hourlyRate * hoursWorked;
        Console.WriteLine($"Salary: {salary}");
    }
}

class Program
{
    public static void Main()
    {
        Employee em;

        // Full-time employee
        em = new FullTimeEmployee(20000.00, 5000.00);
        em.ShowBasicInfo("Full-time Employee", "AS");
        em.CalculateSalary();

        // Part-time employee
        em = new PartTimeEmployee(100.00, 50); // example values
        em.ShowBasicInfo("Part-time Employee", "AS");
        em.CalculateSalary();
    }
}