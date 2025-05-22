using System;
using System.Collections.Generic;

// 1. Course class
public class Course
{
    public int Id { get; set; }
    public string Title { get; set; }
    public decimal Fee { get; set; }
}

// 2. Interface IEnrollable
public interface IEnrollable
{
    void Enroll();
}

// 3. User class with overloaded Enroll() methods
public class User : IEnrollable
{
    public string Name { get; set; }
    private List<(Course course, decimal finalFee)> enrolledCourses = new List<(Course, decimal)>();

    // Enroll with only course
    public void Enroll(Course course)
    {
        enrolledCourses.Add((course, course.Fee));
        Console.WriteLine($"Enrolled {course.Title} for {course.Fee:C}");
    }

    // Enroll with course and coupon code
    public void Enroll(Course course, string couponCode)
    {
        decimal discount = 0;
        // Example: simple coupon logic
        if (couponCode == "DISCOUNT10")
            discount = course.Fee * 0.10m;
        else if (couponCode == "SAVE20")
            discount = course.Fee * 0.20m;
        else
            Console.WriteLine("Invalid coupon code. No discount applied.");

        decimal finalFee = course.Fee - discount;
        enrolledCourses.Add((course, finalFee));
        Console.WriteLine($"Enrolled {course.Title} with coupon '{couponCode}' for {finalFee:C}");
    }

    public void PrintEnrolledCourses()
    {
        Console.WriteLine($"\n{this.Name}'s Enrolled Courses:");
        decimal totalAmount = 0;
        foreach (var (course, fee) in enrolledCourses)
        {
            Console.WriteLine($"- {course.Title}: {fee:C}");
            totalAmount += fee;
        }
        Console.WriteLine($"Total amount payable: {totalAmount:C}");
    }

    public void Enroll()
    {
        // This method can be left empty or implement default behavior
        // For this example, it won't be called directly
    }
}

class Program
{
    static void Main()
    {
        // Creating some verry real courses
        Course course1 = new Course { Id = 101, Title = "C# Fundamentals", Fee = 200 };
        Course course2 = new Course { Id = 102, Title = "ASP.NET Core", Fee = 300 };
        Course course3 = new Course { Id = 103, Title = "Azure Cloud", Fee = 400 };

        User user = new User { Name = "Alice" };

        // Enroll using only course
        user.Enroll(course1);

        // Enroll with coupon code
        user.Enroll(course2, "DISCOUNT10");
        user.Enroll(course3, "SAVE20");
        user.Enroll(course3, "INVALID");

        // Print enrolled courses and total
        user.PrintEnrolledCourses();
    }
}