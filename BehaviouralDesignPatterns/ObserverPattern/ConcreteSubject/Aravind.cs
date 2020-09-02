using ObserverPattern.Observer;
using ObserverPattern.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.ConcreteSubject
{
    public class Aravind : ICelebrity
    {
        private readonly List<IFan> _fans = new List<IFan>();
        private string _tweet;

        public Aravind(string tweet)
        {
            _tweet = tweet;
        }

        public string FullName => "Aravind Siddoju";

        public string Tweet {
            get { return _tweet; }
            set { Notify(value); } }

        public void AddFollower(IFan fan)
        {
            _fans.Add(fan);
        }

        public void Notify(string tweet)
        {
            _tweet = tweet;
            _fans.ForEach(x => x.Update(this));
        }

        public void RemoveFollower(IFan fan)
        {
            _fans.Remove(fan);
        }
    }
}
