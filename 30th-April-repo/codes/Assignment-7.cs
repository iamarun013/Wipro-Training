using System;

public class Program
{
    static int LinearSearch(int[]arr, int n)
    {
        int pos=0;
        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i]==n)
            {
                pos=i;
                break;
            }
        }
        if(pos!=0)
        return pos;
        else
        return 0;
    }
    public static void Main(string[] args)
    {
        int[] array=new int[10];
        for(int i=0;i<10;i++)
        {
            Console.WriteLine($"Enter {i}th element of the array:  ");
            array[i]=Convert.ToInt32(Console.ReadLine());
        }
        int n=5;
        int result=LinearSearch(array, n);
        if(result==0)
        Console.WriteLine("Element not found");
        else
        Console.WriteLine($"Element found at index: {result}");
        
    }
}