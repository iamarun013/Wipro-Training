using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. Input sentence
        string sentence = "C# is great and C# is fun";

        // 2. Split into words (assuming words are separated by spaces)
        string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        // 3. Use LINQ to group by words and count frequency
        var wordCount = words
            .GroupBy(w => w)
            .Select(g => new { Word = g.Key, Count = g.Count() });

        // 4. Print the word counts
        foreach (var item in wordCount)
        {
            Console.WriteLine($"{item.Word}: {item.Count}");
        }
    }
}