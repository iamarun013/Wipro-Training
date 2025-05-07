using System;
class Program
{
    public static void Main()
    {
        String line = "Hi my name is Arunava";
        string word = "";
        string[] arr = line.Split(new[] { " " }, StringSplitOptions.None);
        int ctr = 0;
        foreach(string s in arr){
            if(s.Length>ctr)
            {
                word = s;
                ctr=s.Length;
            }

        }
        Console.WriteLine($"{word} is the largest word and length is {ctr}");
    }

}