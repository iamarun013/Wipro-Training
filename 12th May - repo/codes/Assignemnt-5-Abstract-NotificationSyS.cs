using System;

abstract class Notification
{
    public abstract void Send();

    public void ShowType()
    {
        Console.WriteLine("Sending Notification");
    }
}

class EmailNotification : Notification
{
    public override void Send()
    {
        Console.WriteLine("Sending Email Notification");
    }
}

class SmsNotification : Notification
{
    public override void Send()
    {
        Console.WriteLine("Sending SMS Notification");
    }
}

class Program
{
    public static void Main()
    {
        Notification notification;

        notification = new EmailNotification();
        notification.ShowType();
        notification.Send();

        notification = new SmsNotification();
        notification.ShowType();
        notification.Send();
    }
}