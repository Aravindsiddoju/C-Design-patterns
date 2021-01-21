using FlyWeightPattern.ConcreteFlyweight;
using FlyWeightPattern.FlyWeightInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeightPattern.FlyweightFactory
{
    class ShapeObjectFactory
    {
        private const string V = "Triangle";
        private Dictionary<string, IShape> shapes = new Dictionary<string, IShape>();

        public int GetTotalObjectsCreated
        {
            get { return shapes.Count; }
        }

        public IShape GetShape(string shapeName)
        {
            IShape shape = null;
            if(shapes.TryGetValue(shapeName, out shape))
            {
                return shape;
            }
            else
            {
                switch(shapeName)
                {
                    case "Triangle":
                    {
                        shape = new Triangle();
                        shapes.Add("Triangle", shape);
                        break;
                    }
                    case "Square":
                    {
                        shape = new Square();
                        shapes.Add("Square", shape);
                        break;
                    }
                    default:
                    {
                            Console.WriteLine("The factory cannot create the requested shape");
                            break;
                    }
                }
                return shape;
            }
        }
    }
}
