using Mediator.Colleague;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.ConcreteColleague
{
    public class NonActor : Participant
    {
        public NonActor(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.WriteLine("Mesaage to a Non Actor");
            base.Receive(from, message);
        }
    }
}
