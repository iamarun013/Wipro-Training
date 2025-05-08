using System;
using System.Collections.Generic;

class Student
{
    public int ID { get; set; }
    public string name { get; set; }

}
class Prograam
{
    public static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { ID = 1, name = "Alice" },

            new Student { ID = 2, name = "Bob" },

            new Student { ID = 3, name = "abir" }
        };

        students.Add(new Student { ID = 4, name = "charlie" });
        foreach (var student in students)
        {
            Console.WriteLine($"ID:{student.ID}, Name:{student.name}");
        }

    }
}