using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.SubSystems
{
    public class Bank
    {
        public bool HasSufficientSavings(string student, int amount)
        {
            Console.WriteLine($"The student has sufficient bank savings");
            return true;
        }
    }
}
