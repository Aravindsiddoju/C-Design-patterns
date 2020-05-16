using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //concrete factory 1 
    public class CitiCreditUnionFactory : ICreditUnionFactory
    {
        public override ILoanAccount CreateLoanAccount()
        {
            var citiLoanAccount = new CitiLoanAccount();
            return citiLoanAccount;
        }

        public override ISavingsAccount CreateSavingsAccount()
        {
            var citiSavingsAccount = new CitiSavingsAccount();
            return citiSavingsAccount;
        }
    }
}
