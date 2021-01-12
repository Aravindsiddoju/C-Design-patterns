using Prototype.ConcretePrototype;
using Prototype.PrototypeManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorController colorController = new ColorController();

            colorController["red"] = new Color(255, 0, 0);
            colorController["Green"] = new Color(0, 255, 0);

            //creating new colors using cloing of older colors.
            Color c1 = colorController["red"].Clone() as Color;

            Console.ReadKey();
        }
    }
}
