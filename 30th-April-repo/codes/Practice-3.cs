using System;
class Program{
    static int CountVowels(string input)
    {
        string vowels="aeiou";
        int count=0;
        foreach(char c in input){
            if(vowels.Contains(c)){
                count++;
            }
        }
        return count;
    }
    static void Main()
    {
        string input="Hey Boy you are Awesome";
        Console.WriteLine($"Numer of vowels is: {CountVowels(input)}");
    }
}