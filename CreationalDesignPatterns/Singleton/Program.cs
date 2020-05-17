using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Approach1
            var foo1 = InsurancePolicySingletonApproach1.Instance;
            var boo1 = InsurancePolicySingletonApproach1.Instance;
            var result1 = foo1.Equals(boo1) ? "singleton is working fine" : "singleton have some issues";
            Console.WriteLine($"{result1} for Approach1");

            //Approach2
            var foo2 = InsurancePolicySingletonAppoach2.Instance;
            var boo2 = InsurancePolicySingletonAppoach2.Instance;
            var result2 = foo2.Equals(boo2) ? "singleton is working fine" : "singleton have some issues";
            Console.WriteLine($"{result2} for Approach2");

            //Approach3
            var foo3 = InsurancePolicySingletonAppoach3.Instance;
            var boo3 = InsurancePolicySingletonAppoach3.Instance;
            var result3 = foo3.Equals(boo3) ? "singleton is working fine" : "singleton have some issues";
            Console.WriteLine($"{result3} for Approach3");
        }
    }
}
