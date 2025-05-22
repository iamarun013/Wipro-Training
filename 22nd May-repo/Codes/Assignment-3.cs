using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. Create a dictionary with name as key and phone number as value
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        // 2. Add 3 contacts
        phoneBook.Add("Alice", "123-456-7890");
        phoneBook.Add("Bob", "234-567-8901");
        phoneBook.Add("Charlie", "345-678-9012");

        // 3. Display all contacts
        Console.WriteLine("All contacts in the phone book:");
        foreach (var contact in phoneBook)
        {
            Console.WriteLine($"Name: {contact.Key}, Phone: {contact.Value}");
        }

        // 4. Ask the user for a name and display the phone number if found
        Console.WriteLine("\nEnter a name to look up the phone number:");
        string nameToFind = Console.ReadLine();

        if (phoneBook.TryGetValue(nameToFind, out string phoneNumber))
        {
            Console.WriteLine($"Phone number of {nameToFind} is {phoneNumber}");
        }
        else
        {
            Console.WriteLine($"Sorry, {nameToFind} is not in the phone book.");
        }
    }
}