using System;

class Student
{
    public int RollNumber;
    public string Name;
    public int Marks;

    public void PrintDetails()
    {
        Console.WriteLine($"Roll Number: {RollNumber}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Marks:{Marks}");
    }
}

class Program{
    Student student1 = new Student();
    Student1.RollNumber=101;
    student1.Name="Amit";
    student1.Marks=85;

    student1.PrintDetails();
}