using System;
class Program
{
    public static void Main()
    {
        String line = "Hi my name is Arunava your name is ?";
        string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
        Dictionary<string, int> dic = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (!dic.ContainsKey(word))
            {
                dic.Add(word, 0);
            }
            dic[word]++;
        }

    foreach(var pair in dic)
    {
        Console.WriteLine($"{pair.Key} occurs for {pair.Value} times");
    }
    }
}