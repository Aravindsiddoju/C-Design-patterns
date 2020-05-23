using Decorator.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteComposite
{
    public class CompactCar : Car
    {
        public CompactCar()
        {
            Description = "Compact Car";
        }
        public override int GetCarPrice() => 1000;

        public override string GetDescription() => Description;
    }
}
