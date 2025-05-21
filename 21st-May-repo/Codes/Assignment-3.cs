using System;
using System.Collections.Generic;

class FirstNonRepeatingCharacter
{
    public static char? FindFirstNonRepeatingChar(string input)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        // Count the occurrences of each character
        foreach (char c in input)
        {
            if (charCount.ContainsKey(c))
                charCount[c]++;
            else
                charCount[c] = 1;
        }

        // Find the first character with a count of 1
        foreach (char c in input)
        {
            if (charCount[c] == 1)
                return c;
        }

        // If no non-repeating character found
        return null;
    }

    static void Main()
    {
        string testString = "swiss";
        var result = FindFirstNonRepeatingChar(testString);
        if (result.HasValue)
            Console.WriteLine($"First non-repeating character: {result}");
        else
            Console.WriteLine("No non-repeating character found.");
    }
}