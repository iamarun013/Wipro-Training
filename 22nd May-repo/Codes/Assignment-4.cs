using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }
}

class Program
{
    static void Main()
    {
        // 2. Add 6 students to a list
        List<Student> students = new List<Student>
        {
            new Student { Name = "Alice", Marks = 85 },
            new Student { Name = "Bob", Marks = 92 },
            new Student { Name = "Charlie", Marks = 78 },
            new Student { Name = "Diana", Marks = 88 },
            new Student { Name = "Ethan", Marks = 95 },
            new Student { Name = "Fiona", Marks = 80 }
        };

        // 3. Use LINQ to get the top 3 students by Marks
        var topStudents = students
            .OrderByDescending(s => s.Marks)
            .Take(3);

        // 4. Print the result
        Console.WriteLine("Top 3 students by marks:");
        foreach (var student in topStudents)
        {
            Console.WriteLine($"Name: {student.Name}, Marks: {student.Marks}");
        }
    }
}