using Composite.Composite;
using Composite.Leaf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leaf nodes
            var a = new Employee { EmployeeId = 1, Name = "a", Rating = 1 };
            var b = new Employee { EmployeeId = 2, Name = "b", Rating = 2 };
            var c = new Employee { EmployeeId = 3, Name = "c", Rating = 3 };
            var d = new Employee { EmployeeId = 4, Name = "d", Rating = 4 };
            var e = new Employee { EmployeeId = 5, Name = "e", Rating = 5 };
            var f = new Employee { EmployeeId = 6, Name = "f", Rating = 6 };
            var g = new Employee { EmployeeId = 7, Name = "g", Rating = 7 };

            // Composites
            var s1 = new Manager { EmployeeId = 8, Name = "s1", Rating = 8 };
            var s2 = new Manager { EmployeeId = 9, Name = "s2", Rating = 9 };

            s1.AddSubordinate(a);
            s1.AddSubordinate(b);
            s1.AddSubordinate(c);
            s1.AddSubordinate(d);
            s1.AddSubordinate(e);
            s2.AddSubordinate(f);
            s2.AddSubordinate(g);

            // Client trying to see the employee performance summary.
            a.PerformanceSummary();

            // Client trying to see the manager performance summary.
            s1.PerformanceSummary();

            // Client trying to see the performace summary of subordinates under manager.
            foreach(var employee in s1.SubOrdinates)
            {
                employee.PerformanceSummary();
            }

        }
    }
}
