using FacadePattern.Facade;
using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Facade
            CollegeLoan collegeLoan = new CollegeLoan();

            //Evaluate loan for a studnet(i.e. client)
            bool isEligibleForLoan = collegeLoan.IsEleigible("aravind", 10000000);
            string elegibility = isEligibleForLoan ? "eligible" : "not eligible";
            Console.WriteLine($"The student with name Aravind is {elegibility} for loan.");
            Console.ReadKey();
        }
    }
}
