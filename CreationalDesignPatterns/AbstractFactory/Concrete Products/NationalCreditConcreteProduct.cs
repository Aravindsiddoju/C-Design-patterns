using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // concrete product A2
    public class NationalSavingAccount : ISavingsAccount
    {
        public NationalSavingAccount()
        {
            AcctNo = Guid.NewGuid().ToString();
        }
    }

    //concrete product B2
    public class NationalLoanAccount : ILoanAccount
    {
        public NationalLoanAccount()
        {
            AcctNo = Guid.NewGuid().ToString();
        }
    }
}
