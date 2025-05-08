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
        new employee_names{ID=1, names="Arun" },
        new employee_names{ID=2, names="Arnab"},
        new employee_names{ID=3, names="Abir"},
        new employee_names{ID=4, names="Meghoma"},
        new employee_names{ID=5, names="Bhairav"},
        new employee_names{ID=6, names="Poltu"}
        
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