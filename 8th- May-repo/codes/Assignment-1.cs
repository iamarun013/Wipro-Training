using System;
using System.Collections.Generic;

class Employee{
    public int ID{get; set;}
    public string names{get;, set;}
}

class Program
{
    static void Main()
    {
        List<Employee> employee_names = new List<Employee>();
        {
        new Employee{ID=1, names="Arun" },
        new Employee{ID=2, names="Arnab"},
        new Employee{ID=3, names="Abir"},
        new Employee{ID=4, names="Meghoma"},
        new Employee{ID=5, names="Bhairav"},
        new Employee{ID=6, names="Poltu"}
        
        };
        employee_names.Add(new Employee(ID=7, names="God"))
        
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