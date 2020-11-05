using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.ConcreteElement;

namespace Visitor.ConcreteVisitor
{
    public class VacationVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            var employee = element as Employee;
            //Increase the vacation days by 3.
            employee.VacationDays += 3;
            Console.WriteLine($"{employee.GetType().Name} {employee.Name} vaction days has been increased to {employee.VacationDays}");
        }
    }
}
