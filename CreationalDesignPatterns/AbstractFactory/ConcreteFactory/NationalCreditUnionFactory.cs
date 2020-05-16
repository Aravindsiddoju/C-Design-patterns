using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class NationalCreditUnionFactory : ICreditUnionFactory
    {
        public override ILoanAccount CreateLoanAccount()
        {
            var nationalLoanAccount = new NationalLoanAccount();
            return nationalLoanAccount;
        }

        public override ISavingsAccount CreateSavingsAccount()
        {
            var nationalSavingsAccount = new NationalSavingAccount();
            return nationalSavingsAccount;
        }
    }
}
