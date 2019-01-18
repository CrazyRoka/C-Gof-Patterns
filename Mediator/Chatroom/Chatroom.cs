using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class Chatroom
    {
        Dictionary<string, IParticipant> participants = new Dictionary<string, IParticipant>();

        public void Register(IParticipant participant)
        {
            if (!participants.ContainsKey(participant.Name))
            {
                participants[participant.Name] = participant;
                participant.Chatroom = this;
            }
        }

        public void Send(string from, string to, string message)
        {
            Console.WriteLine($"Chatroom got message: {message}. From: {from}. To: {to}");
            if (to.ToLower() == "all")
            {
                foreach(var pair in participants)
                {
                    if(pair.Value.Name != from)
                        pair.Value.Receive(from, message);
                }
            }
            else
            {
                IParticipant receiver = participants[to];
                if(receiver != null)
                {
                    receiver.Receive(from, message);
                }
            }
        }
    }
}
