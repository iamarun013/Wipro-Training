class Action // if there is return type, use func, no return type use action
{
    public static void Main()
    {
        Action<int> printActionDel = ConsolePrint;
        Action<int> printToPrinter = PrinterPrint;
        printActionDel(10);
        printToPrinter(45);
        Console.Read();
    }

    public static void ConsolePrint(int i)
    {
        Console.WriteLine(i);
    }

    public static void PrinterPrint(int i)
    {
        Console.WriteLine("This is being printed to the printer");
    }
}