using System;
using System.Collections.Generic;

// 1. Interface IAttendance
public interface IAttendance
{
    void MarkAttendance();
}

// 2. Abstract class Staff
public abstract class Staff
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }

    public abstract decimal CalculateSalary();
}

// 3. PermanentStaff class implementing IAttendance and inheriting Staff
public class PermanentStaff : Staff, IAttendance
{
    public decimal BasicPay { get; set; }
    public decimal Allowances { get; set; }

    public void MarkAttendance()
    {
        Console.WriteLine($"Permanent Staff {Name} marked present.");
    }

    public override decimal CalculateSalary()
    {
        // For example, salary = BasicPay + Allowances
        return BasicPay + Allowances;
    }
}

// ContractStaff class implementing IAttendance and inheriting Staff
public class ContractStaff : Staff, IAttendance
{
    public decimal HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public void MarkAttendance()
    {
        Console.WriteLine($"Contract Staff {Name} marked present.");
    }

    public override decimal CalculateSalary()
    {
        // For example, salary based on hours worked
        return HourlyRate * HoursWorked;
    }
}

class Program
{
    static void Main()
    {
        // 4. List of Staff objects demonstrating polymorphism
        List<Staff> staffMembers = new List<Staff>
        {
            new PermanentStaff { Id=1, Name="Alice", Department="HR", BasicPay=3000, Allowances=500 },
            new ContractStaff { Id=2, Name="Bob", Department="IT", HourlyRate=20, HoursWorked=160 },
            new PermanentStaff { Id=3, Name="Charlie", Department="Finance", BasicPay=4000, Allowances=700 }
        };

        foreach (var staff in staffMembers)
        {
            // Mark attendance
            if (staff is IAttendance attendee)
            {
                attendee.MarkAttendance();
            }

            // Display salary
            Console.WriteLine($"Name: {staff.Name}, Department: {staff.Department}, Salary: {staff.CalculateSalary():C}");
        }
    }
}