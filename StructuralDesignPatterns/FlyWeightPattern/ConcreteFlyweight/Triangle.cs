using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeightPattern.FlyWeightInterface
{
    public class Triangle : IShape
    {
        public void Print()
        {
            Console.WriteLine("Printing the triangle");
        }
    }
}
