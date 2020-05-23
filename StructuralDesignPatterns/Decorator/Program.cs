using Decorator.Composite;
using Decorator.ConcreteComposite;
using Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Car theCar = new CompactCar();
            theCar = new Navigation(theCar);
            theCar = new LeatherSheets(theCar);
            theCar = new Sunroof(theCar);

            Console.WriteLine(theCar.GetDescription());
            Console.WriteLine(theCar.GetCarPrice());
        }
    }
}
