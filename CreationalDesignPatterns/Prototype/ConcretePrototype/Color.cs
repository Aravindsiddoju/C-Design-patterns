using Prototype.AbstarctPrototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.ConcretePrototype
{
    public class Color : ColorPrototype
    {
        private int _red;
        private int _yellow;
        private int _orange;

        public Color(int red, int yellow, int orange)
        {
            this._red = red;
            this._yellow = yellow;
            this._orange = orange;
        }

        public override ColorPrototype Clone()
        {
            Console.WriteLine("cloning the item");
            return this.MemberwiseClone() as ColorPrototype;
        }
    }
}
