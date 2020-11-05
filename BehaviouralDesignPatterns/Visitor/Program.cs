using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.ConcreteElement;
using Visitor.ConcreteVisitor;
using Visitor.ObjectStructure;

namespace Visitor
{
    class Program
    {
        
    }

    class Client
    {
        static void Main(string[] args)
        {
            //Object structure
            Employees employees = new Employees();

            //Elements
            Element clerk = new Clerk("Edward", 500, 6);
            Element director = new Director("Jonathan", 600, 8);

            //Visitors
            IVisitor incomeVisitor = new IncomeVisitor();
            IVisitor vacationVisitor = new VacationVisitor();

            // Attach elements to the object structure
            employees.Attach(clerk);
            employees.Attach(director);

            //Perform operation of different visitors.
            employees.Accept(incomeVisitor);
            employees.Accept(vacationVisitor);
        }
    }
}
