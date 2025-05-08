using System;
using System.Collections;

class Program{
    public static void Main(){

            ArrayList num=new ArrayList();
            Random rand=new Random();
            for(int i=1;i<=10;i++){
            num.Add(rand.Next(1,50));
                }
                num.Sort();
                Console.WriteLine($"Smallest element: " + num[0]);
                Console.WriteLine($"largest element: "+ num[9]);
        }
}