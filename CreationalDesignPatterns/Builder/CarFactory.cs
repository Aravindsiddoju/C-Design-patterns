using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// The Director class
    /// </summary>
    public class CarFactory
    {
        public Car build(CarBuilder carBuilder)
        {
            carBuilder.SetHorsePower();
            carBuilder.SetTopSpeed();
            carBuilder.SetImpressiveFeature();
            return carBuilder.GetCar();
        }
    }
}
