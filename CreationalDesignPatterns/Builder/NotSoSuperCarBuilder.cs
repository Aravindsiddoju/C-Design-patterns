using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// Concrete builder class for not so super car.
    /// </summary>
    public class NotSoSuperCarBuilder : CarBuilder
    {
        public override void SetHorsePower()
        {
            _car.HorsePower = 50;
        }

        public override void SetImpressiveFeature()
        {
            _car.MostImpressiveCarFeature = "Has A/C";
        }

        public override void SetTopSpeed()
        {
            _car.TopSpeedMPH = 500;
        }
    }
}
