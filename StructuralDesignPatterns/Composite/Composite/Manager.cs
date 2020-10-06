using Composite.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Composite
{
    /// <summary>
    /// This is the composite class(i.e. non leaf node in the tree structure).
    /// It contains composition of other objects inside it.
    /// </summary>
    public class Manager : IEmployee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }

        public List<IEmployee> SubOrdinates { get { return subOrdinates; } }

        private List<IEmployee> subOrdinates = new List<IEmployee>();

        public void PerformanceSummary()
        {
            Console.WriteLine($"The performance rating of the supervisor {Name} with employee Id:{EmployeeId} is {Rating}.");
        }

        public void AddSubordinate(IEmployee employee)
        {
            subOrdinates.Add(employee);
        }
    }
}
