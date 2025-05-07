using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList List = new ArrayList();
        List.Add("APPLE");
        List.Add(42);
        List.Add(3.14);
            
        foreach ( var item in List)    
            {
                Console.WriteLine(item);
            }
            Console.Read();
            }

}