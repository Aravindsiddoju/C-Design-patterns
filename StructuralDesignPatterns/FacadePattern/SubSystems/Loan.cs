using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.SubSystems
{
    public class Loan
    {
        public bool HasNoBadLoans(string student)
        {
            Console.WriteLine($"The student has no bad loans.");
            return true;
        }
    }
}
