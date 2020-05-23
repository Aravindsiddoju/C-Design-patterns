using Decorator.Composite;
using Decorator.ConcreteDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
    public class Sunroof : CarDecorator
    {
        public Sunroof(Car car) : base(car)
        {
            Description = "Sunroof";
        }
        public override int GetCarPrice()
        {
            return _car.GetCarPrice() + 2500;
        }

        public override string GetDescription()
        {
            return $"{_car.GetDescription()}, {Description}";
        }
    }
}
