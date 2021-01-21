using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.SubSystems
{
    public class Credit
    {
        public bool HasGoodCreditScore(string student)
        {
            Console.WriteLine($"The student has a good credit score");
            return true;
        }
    }
}
