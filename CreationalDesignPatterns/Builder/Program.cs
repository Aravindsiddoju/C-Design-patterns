using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var superCarBuilder = new SuperCarBuilder();
            var notSoSuperCarBuilder = new NotSoSuperCarBuilder();

            var carFactory = new CarFactory();
            var carBuilders = new List<CarBuilder> { superCarBuilder, notSoSuperCarBuilder };

            foreach(var builder in carBuilders)
            {
                var car = carFactory.build(builder);

                Console.WriteLine("The Car requested by " +
                    $"{builder.GetType().Name}: " +
                    $"\n--------------------------------------------------" +
                    $"\nHorse Power: {car.HorsePower} " +
                    $"\nImpressive feature: {car.MostImpressiveCarFeature} " +
                    $"\nTop Speed: {car.TopSpeedMPH} mph\n");
            }
        }
    }
}
