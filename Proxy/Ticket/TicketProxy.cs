using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    class TicketProxy : ITicket
    {
        private int _id;
        private bool cached = false;
        private ITicket ticket;
        public TicketProxy() => ticket = new TicketDB();

        public int GetId()
        {
            if (!cached)
            {
                _id = ticket.GetId();
                cached = true;
            }
            return _id;
        }
    }
}
