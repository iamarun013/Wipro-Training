
using System;

public class Program
{
    static void PrintArray(int[] arr)
    {
       for(int i=0;i<arr.Length;i++)
       {
           Console.WriteLine($"Elements at {i+1} index is : {arr[i]}");
       }
    }
    static void Main()
    {
        int[] numbers={19, 23, 34, 56, 67, 84, 33};
        PrintArray(numbers);       
    }

}