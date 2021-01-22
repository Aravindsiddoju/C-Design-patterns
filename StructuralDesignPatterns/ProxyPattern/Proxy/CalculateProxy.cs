using ProxyPattern.Real_Subject;
using ProxyPattern.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern.Proxy
{
    public class CalculateProxy : IMath
    {
        private IMath concreteSubject = new Maths();
        public void Add(int a, int b)
        {
            concreteSubject.Add(a, b);
        }

        public void Divide(int a, int b)
        {
            concreteSubject.Divide(a, b);
        }

        public void Multiply(int a, int b)
        {
            concreteSubject.Multiply(a, b);
        }

        public void Subtract(int a, int b)
        {
            concreteSubject.Subtract(a, b);
        }
    }
}
