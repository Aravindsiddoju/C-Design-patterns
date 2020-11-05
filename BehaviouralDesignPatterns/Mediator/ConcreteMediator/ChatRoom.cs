using Mediator.Colleague;
using Mediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.ConcreteMediator
{
    /// <summary>
    /// Concrete Mediator.
    /// </summary>
    public class ChatRoom : AbstractChatRoom
    {
        private Dictionary<string, Participant> _participants = new Dictionary<string, Participant>();
        public override void Register(Participant participant)
        {
           if(!_participants.ContainsKey(participant.Name))
            {
                _participants[participant.Name] = participant;
            }
        }

        public override void Send(string from, string to, string message)
        {
            Participant receiver;
            if(_participants.TryGetValue(to, out receiver))
            {
                receiver.Receive(from, message);
            }
            else
            {
                Console.WriteLine("Sorry the message cannot be delivered since the receiver is not registered.");
            }
        }
    }
}
