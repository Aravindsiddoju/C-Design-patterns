using Decorator.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteDecorator
{
    public class CarDecorator : Car
    {
        protected Car _car;

        public CarDecorator(Car car)
        {
            _car = car;
        }
        public override int GetCarPrice() => _car.GetCarPrice();

        public override string GetDescription() => _car.GetDescription();
    }
}
