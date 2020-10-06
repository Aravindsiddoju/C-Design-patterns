using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Component
{
    public interface IEmployee
    {
        /// <summary>
        /// This is the component interface.
        /// This will be used as a generic API to treat both composite and leaf object equally for accessing.
        /// </summary>
        int EmployeeId { get; set; }

        string Name { get; set; }

        int Rating { get; set; }

        void PerformanceSummary();
    }
}
