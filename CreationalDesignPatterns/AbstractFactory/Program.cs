using AbstractFactory.FactoryProvider;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> acctNumbers = new List<string>
            {
                "CITI-123",
                "NATIONAL-234"
            };
            foreach(var acctNo in acctNumbers)
            {
                ICreditUnionFactory creditUnionFactory = CreditUnionFactoryProvider.GetCreditUnionFactory(acctNo);
                ISavingsAccount savingsAccount = creditUnionFactory.CreateSavingsAccount();
                ILoanAccount loanAccount = creditUnionFactory.CreateLoanAccount();
                Console.WriteLine($"your loan account is successfully created with AcctNO:{loanAccount.AcctNo} \n"
                    + $"your savings account is successfully created with AcctNO:{savingsAccount.AcctNo} \n");
            }
            Console.ReadLine();
        }
    }
}
