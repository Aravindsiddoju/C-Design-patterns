using ObserverPattern.Observer;
using ObserverPattern.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.ConcreteObserver
{
    public class Fan : IFan
    {
        private string _name;

        public Fan(string name)
        {
            _name = name;
        }

        public void Update(ICelebrity celebrity)
        {
            Console.WriteLine($"The fan {_name} has been notified for the tweet: {celebrity.Tweet} from the celebrity {celebrity.FullName}");
        }
    }
}
