using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeightPattern.ConcreteFlyweight
{
    public class Square : IShape
    {
        public void Print()
        {
            Console.WriteLine("Printing the square");
        }
    }
}
