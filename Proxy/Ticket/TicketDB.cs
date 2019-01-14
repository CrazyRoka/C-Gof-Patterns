using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class TicketDB : ITicket
    {
        private int _id;
        public TicketDB() => _id = new Random().Next();

        public int GetId()
        {
            Console.WriteLine("Making DB request");
            Task.Delay(2000).Wait();
            Console.WriteLine("Fetched result from DB");
            return _id;
        }
    }
}
