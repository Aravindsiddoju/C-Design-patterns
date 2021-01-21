using FlyWeightPattern.FlyweightFactory;
using System;

namespace FlyWeightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeObjectFactory sof = new ShapeObjectFactory();

            IShape shape = sof.GetShape("Triangle");
            shape.Print();
            shape = sof.GetShape("Triangle");
            shape.Print();
            shape = sof.GetShape("Triangle");
            shape.Print();
            shape = sof.GetShape("Triangle");
            shape.Print();

            shape = sof.GetShape("Square");
            shape.Print();
            shape = sof.GetShape("Square");
            shape.Print();
            shape = sof.GetShape("Square");
            shape.Print();
            shape = sof.GetShape("Square");
            shape.Print();
            shape = sof.GetShape("Square");
            shape.Print();

            int totalObjectCount = sof.GetTotalObjectsCreated;
            Console.WriteLine($"The total number of objects created are {totalObjectCount}.");
            Console.ReadKey();
        }
    }
}
