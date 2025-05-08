using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Dictionary<string, string> phoneDirectory = new Dictionary<string, string>{
            {"Arunava", "8509470320"},
            {"Chanda", "9734868632"},
            {"Meghoma", "998877665"},
            {"Poltu", "9876390212 "},
            {"Amitui", "9875213489"}
             };

        phoneDirectory["Poltu"] = "9845732391";
        if (phoneDirectory.ContainsKey("Arunava"))
        {
            Console.WriteLine("Yea it exists");
        }
        else
        {
            Console.WriteLine("No it doesn't exist");


        }
        foreach (var item in phoneDirectory)
        {
            Console.WriteLine(item);
        }
    }
}
