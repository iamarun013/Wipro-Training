using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringAnalyzerTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a paragraph:");
            string paragraph = Console.ReadLine();

            // Normalize the text: remove punctuation, convert to lowercase
            string cleanedText = Regex.Replace(paragraph.ToLower(), @"[^\w\s]", "");

            // Split into words
            string[] words = cleanedText.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Count word frequency
            var wordFrequency = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (wordFrequency.ContainsKey(word))
                    wordFrequency[word]++;
                else
                    wordFrequency[word] = 1;
            }

            // Count vowels and consonants
            int vowelCount = 0;
            int consonantCount = 0;
            foreach (char c in cleanedText)
            {
                if (char.IsLetter(c))
                {
                    if ("aeiou".Contains(c))
                        vowelCount++;
                    else
                        consonantCount++;
                }
            }

            // Find longest and shortest words
            string longestWord = words.OrderByDescending(w => w.Length).FirstOrDefault() ?? "";
            string shortestWord = words.OrderBy(w => w.Length).FirstOrDefault() ?? "";

            // Display results
            Console.WriteLine("\nWord Frequency:");
            foreach (var kvp in wordFrequency.OrderBy(k => k.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            Console.WriteLine($"\nTotal vowels: {vowelCount}");
            Console.WriteLine($"Total consonants: {consonantCount}");
            Console.WriteLine($"Longest word: {longestWord}");
            Console.WriteLine($"Shortest word: {shortestWord}");
        }
    }
}
}