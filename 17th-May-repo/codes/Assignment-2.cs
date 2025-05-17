using System;
interface ISupportTicket
{
    void CreateTicket(string issue);
    void ResolveTicket(int ticketId);
}

class EmailSupport:ISupportTicket
{
    public void CreateTicket(string issue)
    {
        Console.WriteLine($"Creating ticket via Email:[{issue}]");
    }
    public void ResolveTicket(int ticketId)
    {
        Console.WriteLine($"Resolving ticket [{ticketId}] via Email");

    }


}
class PhoneSupport:ISupportTicket
{
    public void CreateTicket(string issue)
    {
        Console.WriteLine($"Creating ticket via Phone:[{issue}]");
    }
    public void ResolveTicket(int ticketId)
    {
        Console.WriteLine($"Resolving ticket [{ticketId}] via Phone");
    }
}

class Program{
    public static void Main()
    {
        ISupportTicket obj=new EmailSupport();
        obj.CreateTicket("Laptop getting heated");
                obj.ResolveTicket(129);

        obj = new PhoneSupport();
                obj.CreateTicket("Phone's whatsapp is not accepting voice calls");

        obj.ResolveTicket(169);
    }
}