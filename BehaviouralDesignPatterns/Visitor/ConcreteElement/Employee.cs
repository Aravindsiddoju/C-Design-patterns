using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.ConcreteElement
{
    public class Employee : Element
    {
        public string Name { get; set; }

        public double Income { get; set; }

        public int VacationDays{ get; set; }

        public Employee(string name, double income, int vacationDays)
        {
            Name = name;
            Income = income;
            VacationDays = vacationDays;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Clerk : Employee
    {
        public Clerk(string name, double income, int vacationDays) : base(name, income, vacationDays)
        {
        }
    }

    public class Director : Employee
    {
        public Director(string name, double income, int vacationDays) : base(name, income, vacationDays)
        {
        }
    }
}
