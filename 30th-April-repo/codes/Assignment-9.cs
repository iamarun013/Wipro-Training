// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        int[] input =new int[10];
        int[] unique =new int[10];
        int unique_count=0;

// Delclaring array variables
        for(int i=0;i<10;i++)
        {
            Console.WriteLine($"Enter {i}th element of the array:  ");
            input[i]=Convert.ToInt32(Console.ReadLine());
        }
        
        
     for(int i=0;i<input.Length;i++)
     {
         bool isduplicate=false;
         for(int j=0;j<unique_count;j++)
         {
             if(input[i]==unique[j])
             {
                 isduplicate=true;
                 break;
             }
         }
         if(!isduplicate){
             unique[unique_count]=input[i];
             unique_count++;
         }
         
         
     }
     
     
     Console.WriteLine("Final array after removing duplicates is:");
     for(int i=0;i<unique_count;i++)
        {
            Console.WriteLine(unique[i]);
        }
    }
}