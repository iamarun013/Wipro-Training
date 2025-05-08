using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> employee_names = new List<string>();
        employee_names.Add("Arun");
        employee_names.Add("Arnab");
        employee_names.Add("Abir");
        employee_names.Add("Meghoma");
        employee_names.Add("bhairav");
        employee_names.Add("Poltu");

        employee_names.Remove("Poltu");
        if (employee_names.Contains("abir"))

        {
            Console.WriteLine("Exists");
        }
        else
            Console.WriteLine("Doesnot exist");
        Console.WriteLine(employee_names.Count);




    }
}