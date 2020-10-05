using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptor
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //}
    }

    class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee list from third party organisation system");
            Console.WriteLine("--------------------------------------------------");

            // Client will use ITarget interface to call the functionality of the Adaptee class(i.e. ThirdPartyEmployee).

            ITarget adapterForThirdPartyEmployee = new EmployeeAdaptor();

            foreach(string employee in adapterForThirdPartyEmployee.GetEmployees())
            {
                Console.WriteLine(employee);
            }
        }
    }
}
