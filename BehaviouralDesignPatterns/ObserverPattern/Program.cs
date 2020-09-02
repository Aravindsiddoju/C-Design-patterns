using ObserverPattern.ConcreteObserver;
using ObserverPattern.ConcreteSubject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var celebrity = new Aravind("Coding is fun");

            var fan1 = new Fan("fan1");
            var fan2 = new Fan("fan2");

            celebrity.AddFollower(fan1);
            celebrity.AddFollower(fan2);

            celebrity.Tweet = "I have implemented the observer pattern successfully";

            Console.ReadLine();
        }
    }
}
