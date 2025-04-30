// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class Program
{
    static void Counting(int[]arr)
    {
        HashSet<int> Printed=new HashSet<int>();
        for(int i=0;i<arr.Length;i++)
        {
            if(!Printed.Contains(arr[i])){
            int counter=0;
            for(int j=0;j<arr.Length;j++)
            {
                if(arr[i]==arr[j])
                {
                    counter+=1;
                }
                
            }
            Console.WriteLine($"{arr[i]} occurs {counter} times.");
            Printed.Add(arr[i]);
        }
        }
    }
    public static void Main(string[] args)
    {
        int[] array=new int[10];
        for(int i=0;i<10;i++)
        {
            Console.WriteLine($"Enter {i}th element of the array:  ");
            array[i]=Convert.ToInt32(Console.ReadLine());
        }
        Counting(array);
        
    }
}