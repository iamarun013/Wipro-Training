using System;
//Define a custom delegate that has a string parameter
delegate void CustomDel(string s);
class TestClass
{
    static void Hello(string s)
    {
        Console.WriteLine($"Hello, {s}!");
    }
    static void GoodBye(string s)
    {
        Console.WriteLine($" Goodbye, {s}!");
    }

    static void Main()
    {
        //Declare instances of the custom delegates
        CustomDel hiDel, byeDel, multiDel, multiminusDel;

        hiDel = Hello;

        byeDel = GoodBye;

        multiDel = hiDel + byeDel;
        multiminusDel = multiDel - hiDel;


        Console.WriteLine("Invoking delegate hiDel: ");
        hiDel("A");
        Console.WriteLine("Invoking delegate byeDel: ");
        byeDel("B");
        Console.WriteLine("Invoking delegate multiDel");
        multiDel("C");
        Console.WriteLine("Invoking delegate multiDel");
        multiminusDel("D");
    }
}