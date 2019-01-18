using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    interface IParticipant
    {
        string Name { get; }
        Chatroom Chatroom { get; set; }

        void Send(string to, string message);

        void Receive(string from, string message);
    }
}
