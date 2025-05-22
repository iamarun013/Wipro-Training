using System;
using System.Collections.Generic;
using System.Linq;

// 1. Define the Student class
public class Student
{
    public string Name { get; set; }
    public double Marks { get; set; }
}

class Program
{
    static void Main()
    {
        // 2. Add at least 5 students
        List<Student> students = new List<Student>
        {
            new Student { Name = "Alice", Marks = 85 },
            new Student { Name = "Bob", Marks = 78 },
            new Student { Name = "Charlie", Marks = 92 },
            new Student { Name = "Diana", Marks = 88 },
            new Student { Name = "Ethan", Marks = 73 }
        };

        // 3. Calculate average marks using LINQ
        double averageMarks = students.Average(s => s.Marks);
        Console.WriteLine($"Average Marks: {averageMarks:F2}");

        // 4. Count students who scored above the average
        int countAboveAverage = students.Count(s => s.Marks > averageMarks);
        Console.WriteLine($"Number of students above average: {countAboveAverage}");
    }
}