using FacadePattern.SubSystems;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Facade
{
    public class CollegeLoan
    {
        Bank bank = new Bank();
        Loan loan = new Loan();
        Credit credit = new Credit();

        public bool IsEleigible(string student, int amount)
        {
            Console.WriteLine($"student named {student} applied for a loan of amount {amount}.");
            bool eligible = true;

            //verify the credit worthyness of student
            if(!bank.HasSufficientSavings(student, amount))
            {
                eligible = false;
            }
            else if(!credit.HasGoodCreditScore(student))
            {
                eligible = false;
            }
            else if(!loan.HasNoBadLoans(student))
            {
                eligible = false;
            }
            return eligible;
        }
    }
}
