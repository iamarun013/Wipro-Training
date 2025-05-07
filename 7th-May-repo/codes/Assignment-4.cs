using System;
using System.Collections;

class Program
{
    public static void Main()
    {
        ArrayList list = new ArrayList();
        list.Add("Arun");
        list.Add("barun");
        list.Add("abir");
        list.Add("arnab");
        list.Add("Megh");

        Console.WriteLine("Before changes made the list is as follows");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    

        if(list.Contains("abir"))
        {
            Console.WriteLine("The name abir exists in the list");
        }
        else
        {
            Console.WriteLine("The name doesn't exist");
        }

        list.RemoveAt(1);

        Console.WriteLine("Before changes made the list is as follows");

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }

}