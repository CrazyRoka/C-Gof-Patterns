using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class Participant : IParticipant
    {
        public string Name { get; }
        public Participant(string name) => Name = name;

        public Chatroom Chatroom { get; set; }

        public void Receive(string from, string message)
        {
            Console.WriteLine($"{Name} received message from {from}. Message: {message}");
        }

        public void Send(string to, string message)
        {
            Console.WriteLine($"{Name} sends message to {to}. Message: {message}");
            Chatroom.Send(Name, to, message);
        }
    }
}
