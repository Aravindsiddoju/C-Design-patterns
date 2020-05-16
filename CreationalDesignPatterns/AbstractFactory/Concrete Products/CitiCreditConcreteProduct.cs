using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //concrete product A1
    public class CitiSavingsAccount : ISavingsAccount
    {
        public CitiSavingsAccount()
        {
            AcctNo = Guid.NewGuid().ToString();
        }
    }

    //concrete product B1
    public class CitiLoanAccount : ILoanAccount
    {
        public CitiLoanAccount()
        {
            AcctNo = Guid.NewGuid().ToString();
        }
    }
}
