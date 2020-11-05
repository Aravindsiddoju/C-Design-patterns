using Mediator.Colleague;
using Mediator.ConcreteColleague;
using Mediator.ConcreteMediator;
using Mediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
       
    }

    class Client
    {
        static void Main(string[] args)
        {
            //Initialize the Mediator and colleagues 
            AbstractChatRoom chatRoom = new ChatRoom();
            Participant ross = new Actor("Ross");
            ross.ChatRoom = chatRoom;
            Participant rachel = new Actor("Rachel");
            rachel.ChatRoom = chatRoom;
            Participant monica = new NonActor("Monica");
            monica.ChatRoom = chatRoom;
            Participant phoebe = new NonActor("Phoebe");
            phoebe.ChatRoom = chatRoom;
            Participant joey = new Actor("Joey");
            joey.ChatRoom = chatRoom;
            Participant chandler = new Actor("Chandler");
            chandler.ChatRoom = chatRoom;

            //Register the colleagues to the mediator
            chatRoom.Register(ross);
            chatRoom.Register(rachel);
            chatRoom.Register(monica);
            chatRoom.Register(phoebe);
            chatRoom.Register(joey);
            chatRoom.Register(chandler);

            //Send messages between the participants.
            joey.Send("Chandler", "How you doing");
            chandler.Send("Monica", "How are you dear");
            monica.Send("Ross", "How are you brother");
            ross.Send("Rachel", "How are you rachel");
            rachel.Send("Phoebe", "You are a good human");
            phoebe.Send("Joey", "Let's party");
        }
    }
}
