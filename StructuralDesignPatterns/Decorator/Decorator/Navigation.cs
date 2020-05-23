using Decorator.Composite;
using Decorator.ConcreteDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
    public class Navigation : CarDecorator
    {
        public Navigation(Car car) : base(car)
        {
            Description = "Navigation";
        }
        public override int GetCarPrice()
        {
            return _car.GetCarPrice() + 5000;
        }

        public override string GetDescription()
        {
            return $"{ _car.GetDescription()}, {Description}";
        }

    }
}
