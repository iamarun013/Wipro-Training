
using System;

public class Program
{
    static void PrintArray(int[] arr)
    {
        Console.WriteLine("Array reversed");
       for(int i=arr.Length-1;i>=0;i--)
       {
           Console.WriteLine($"Elements at {i} index is : {arr[i]}");
       }
    }
    static void Main()
    {
        int[] numbers={19, 23, 34, 56, 67, 84, 33};
        PrintArray(numbers);       
    }

}