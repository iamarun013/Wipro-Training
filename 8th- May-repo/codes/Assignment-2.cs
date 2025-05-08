using System;
using System.Collections;

class Program
{
    public static void Main()
    {
        ArrayList student = new ArrayList();
        student.Add("Abhi");
        student.Add("Varun");
        student.Add("Rohit");
        student.Add("Abdul");
        student.Add("Vivek");

        // Remove "Abdul" from list
        student.Remove("Abdul");

        // Print all students
        foreach (var item in student)
        {
            Console.WriteLine(item);
        }

        // Check for "Abhi"
        if (student.Contains("Abhi"))
        {
            Console.WriteLine("Yes, Abhi name exists");
        }
        else
        {
            Console.WriteLine("Abhi name does not exist");
        }
    }
}