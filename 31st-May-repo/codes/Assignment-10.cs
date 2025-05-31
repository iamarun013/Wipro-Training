using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Dictionary to store student name and list of marks
        Dictionary<string, List<int>> studentMarks = new Dictionary<string, List<int>>()
        {
            { "Alice", new List<int> { 85, 92, 78 } },
            { "Bob", new List<int> { 90, 88, 94 } },
            { "Charlie", new List<int> { 70, 75, 80 } },
            { "David", new List<int> { 95, 85, 87 } },
            { "Eve", new List<int> { 88, 92, 85 } }
        };

        // Calculate and display stats per student
        Console.WriteLine("Student Statistics:\n");
        foreach (var student in studentMarks)
        {
            string name = student.Key;
            List<int> marks = student.Value;

            double average = marks.Average();
            int highest = marks.Max();
            int lowest = marks.Min();

            Console.WriteLine($"{name}:");
            Console.WriteLine($"  Average: {average:F2}");
            Console.WriteLine($"  Highest: {highest}");
            Console.WriteLine($"  Lowest: {lowest}\n");
        }

        // Find top 3 scorers based on average marks
        var topScorers = studentMarks
            .Select(s => new
            {
                Name = s.Key,
                Average = s.Value.Average()
            })
            .OrderByDescending(s => s.Average)
            .Take(3);

        Console.WriteLine("Top 3 Scorers:");
        int rank = 1;
        foreach (var student in topScorers)
        {
            Console.WriteLine($"{rank}. {student.Name} - Average: {student.Average:F2}");
            rank++;
        }
    }
}