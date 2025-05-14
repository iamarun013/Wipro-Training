using System;

abstract class TicketBooking
{
    public abstract void TicketBooking(int seats);
    public void ShowBookingInfo()
    {
        Console.WriteLine("Booking Tickets");
    }
}

class BusBooking : TicketBooking
{
    public override void TicketBooking(int seats)
    {
        Console.WriteLine($"Booking {seats} bus tickets");
    }
}

class FlightBooking : TicketBooking
{
    public override void TicketBooking(int seats)
    {
        Console.WriteLine($"Booking {seats} flight tickets");
    }
}

class Program
{
    public static void Main()
    {
        TicketBooking tb;

        tb = new BusBooking();
        tb.TicketBooking(3);  // specify number of seats
        tb.ShowBookingInfo();

        tb = new FlightBooking();
        tb.TicketBooking(2);  // specify number of seats
        tb.ShowBookingInfo();
    }
}