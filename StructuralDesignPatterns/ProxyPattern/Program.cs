using ProxyPattern.Proxy;
using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // create the maths proxy
            CalculateProxy calculateProxy = new CalculateProxy();

            // do some math using proxy
            calculateProxy.Add(2, 3);
            calculateProxy.Multiply(2, 3);
            calculateProxy.Subtract(2, 3);
            calculateProxy.Divide(3, 2);

            Console.ReadKey();

        }
    }
}
