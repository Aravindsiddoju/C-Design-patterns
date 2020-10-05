using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class SuperCarBuilder : CarBuilder
    {
        public override void SetHorsePower()
        {
            _car.HorsePower = 100;
        }

        public override void SetImpressiveFeature()
        {
            _car.MostImpressiveCarFeature = "Has Wifi connectivity";
        }

        public override void SetTopSpeed()
        {
            _car.TopSpeedMPH = 1000;
        }
    }
}
