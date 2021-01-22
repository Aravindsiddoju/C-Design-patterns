using ProxyPattern.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern.Real_Subject
{
    public class Maths : IMath
    {
        public void Add(int a, int b)
        {
            Console.WriteLine($"The sum of {a} and {b} is {a+b}");
        }

        public void Divide(int a, int b)
        {
            Console.WriteLine($"The divison of {a} and {b} is {a / b}");
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine($"The multiplication of {a} and {b} is {a * b}");
        }

        public void Subtract(int a, int b)
        {
            Console.WriteLine($"The subtraction of {a} and {b} is {a - b}");
        }
    }
}
