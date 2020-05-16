using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.FactoryProvider
{
    public class CreditUnionFactoryProvider
    {
        public static ICreditUnionFactory GetCreditUnionFactory(string acctNo)
        {
            if(acctNo.Contains("CITI"))
            {
                var citiCreditUnionFactory = new CitiCreditUnionFactory();
                return citiCreditUnionFactory;
            }
            else if(acctNo.Contains("NATIONAL"))
            {
                var nationalCreditUnionFactory = new NationalCreditUnionFactory();
                return nationalCreditUnionFactory;
            }
            else
            {
                throw new ArgumentException("invalid account number");
            }
        }
    }
}
