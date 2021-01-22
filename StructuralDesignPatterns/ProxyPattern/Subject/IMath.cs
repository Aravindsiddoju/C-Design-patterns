using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern.Subject
{
    public interface IMath
    {
        void Add(int a, int b);
        void Subtract(int a, int b);
        void Divide(int a, int b);
        void Multiply(int a, int b);
    }
}
