using System;
using System.Diagnostics;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using non cached ticket");
            var watch = Stopwatch.StartNew();
            ITicket nonCachedEnity = new TicketDB();
            Console.WriteLine($"Ticket id equal = {nonCachedEnity.GetId()}");
            Console.WriteLine("Fetch one more time");
            Console.WriteLine($"Ticket id equal = {nonCachedEnity.GetId()}");
            watch.Stop();
            Console.WriteLine($"Using non cached - elapsed {watch.ElapsedMilliseconds} milliseconds");

            Console.WriteLine("Using cached ticket");
            watch.Restart();
            ITicket proxy = new TicketProxy();
            Console.WriteLine($"Ticket id equal = {proxy.GetId()}");
            Console.WriteLine("Fetch one more time");
            Console.WriteLine($"Ticket id equal = {proxy.GetId()}");
            watch.Stop();
            Console.WriteLine($"Using cached - elapsed {watch.ElapsedMilliseconds} milliseconds");
        }
    }
}
