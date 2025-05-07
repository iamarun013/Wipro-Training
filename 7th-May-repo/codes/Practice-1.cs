using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList List = new ArrayList();
        List.Add("APPLE");
        List.Add(42);
        List.Add(3.14);
        List.Add("grape");
        List.Add(433);
        List.Add(5.14);


        foreach (var item in List)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("Press enter to continue");

        Console.Read();

        // inserting an element at position 1
        List.Insert(1, "inserted");

        List.Remove("grape");
        List.RemoveAt(2);
        foreach (var item in List)
        {
            Console.WriteLine(item);
        }
        //Conatins an element or not

        if (List.Contains("APPLE"))
        {
            Console.WriteLine("The list contains grapes");
        }
        else
            Console.WriteLine("The list doesnot contain grapes");
        Console.Read();


    }
}