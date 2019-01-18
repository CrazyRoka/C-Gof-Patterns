using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Chatroom chatroom = new Chatroom();

            IParticipant roka = new Participant("Roka");
            IParticipant john = new Participant("John");
            IParticipant igor = new Participant("Igor");
            IParticipant ruslan = new Participant("Ruslan");
            IParticipant bodya = new Participant("Bodya");

            chatroom.Register(roka);
            chatroom.Register(john);
            chatroom.Register(igor);
            chatroom.Register(ruslan);
            chatroom.Register(bodya);

            roka.Send("all", "Hello, everybody!");
            john.Send("Roka", "Hi, Roka!");
            igor.Send("Ruslan", "How are you?");
            bodya.Send("Ruslan", "Do not answer!");
            ruslan.Send("Igor", "...");
            roka.Send("all", "Bye!");
        }
    }
}
