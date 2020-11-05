using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.ConcreteElement;

namespace Visitor.ObjectStructure
{
    // Object structure class
    class Employees
    {
        private List<Element> employees = new List<Element>();

        public void Attach(Element employee)
        {
            employees.Add(employee);
        }

        public void Detach(Element employee)
        {
            employees.Remove(employee);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (Element employee in employees)
            {
                employee.Accept(visitor);
            }
        }
    }
}
