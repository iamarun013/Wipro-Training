using System;
class Program
{
    public static void Main()
    {
            Console.WriteLine("Hello Enter a string");
            string arr=Console.ReadLine();
            int Count = 0;
            for(int i = 0;i<arr.Length;i++)
            {
                if (arr[i]==' ') { 
                
                    Count = Count + 1;
                }

            }
        Console.WriteLine(Count);

    }
}

