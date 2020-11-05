using Mediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Colleague
{
    /// <summary>
    /// Colleague.
    /// </summary>
    public class Participant
    {
        private AbstractChatRoom _chatRoom;
        private string _name;

        public Participant(string name)
        {
            _name = name;
        }

        public string Name { get { return _name; } }

        public AbstractChatRoom ChatRoom
        {
            get { return _chatRoom; }
            set { _chatRoom = value; }
        }

        public void Send(string to, string message)
        {
            _chatRoom.Send(Name, to, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine($"{from} ----- {_name} =====>>>> {message}");
        }
    }
}
