using Mediator.Colleague;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.ConcreteColleague
{
    public class Actor : Participant
    {
        public Actor(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.WriteLine("Message to the Actor:");
            base.Receive(from, message);
        }
    }
}
