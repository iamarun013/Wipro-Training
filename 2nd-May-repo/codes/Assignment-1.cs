using System;
class Program{
    
    static int Palindrome(string str)
    {
        str=str.Trim().ToLower();
       int left=0;
       int right=(str.Length)-1;
       
       while(left<right)
       {
           if(str[left]!=str[right])
           {
               return -1;
           }
           left++;
           right--;
       }
       return 1;
    }
   
    static void Main()
    {
        
        Console.WriteLine("Enter the input to check for palindrome");
        string n=Console.ReadLine();

       int result= Palindrome(n);
       if(result==1)
       Console.WriteLine("Palindrome");
       else
       Console.WriteLine("Not Palindrome");
           }
    
}