using Composite.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Leaf
{
    /// <summary>
    /// This is the Leaf Node in the tree structure.
    /// It does not contain any composition of objects inside it.
    /// </summary>
    public class Employee : IEmployee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }

        public void PerformanceSummary()
        {
            Console.WriteLine($"The performace Rating of {Name} with employee Id:{EmployeeId} is {Rating}");
        }
    }
}
