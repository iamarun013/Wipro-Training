using System;
using System.Data;
class Program
{
    static int Countfreq(int[] arr,int[] freq)
    {
   ;
        int c;
        c= 0;
        for (int i = 0; i < arr.Length; i++)
        {
            c = 0;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    c++;
                    freq[j] = 0;
                }
            }
            if (freq[i]!=0)
            {
                freq[i] = c;
            }
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"{arr[i]} frquency is : {freq[i]}");
        }
        return 0;
    }
    public static void Main(string[] args)
    {
        int n=Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        int[] arr2 = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Countfreq(arr,arr2);

        
    }
}