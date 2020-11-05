using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.ConcreteElement;

namespace Visitor.ConcreteVisitor
{
    //Concrete visitor class
    public class IncomeVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            var employee = element as Employee;
            if(employee == null)
            {
                return;
            }
            //provide a 20% pay raise.
            employee.Income += employee.Income * (0.2);
            Console.WriteLine($"{employee.GetType().Name} {employee.Name} income is increased to {employee.Income}");
        }
    }
}
