using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new SavingsAccountFactory() as ICreditUnionFactory;
            var citiAcct = factory.GetSavingsAccount("CITI-123");
            var nationalAccount = factory.GetSavingsAccount("NATIONAL-987");
            Console.WriteLine($"my citi acct balance is {citiAcct.Balance}"
                + "\n"
                + $"my national acct balance is {nationalAccount.Balance}");
            Console.ReadLine();
        }
    }

    //product
    public abstract class ISavingsAccount
    {
        public decimal Balance { get; set; }
    }

    //concrete product
    public class CitiSavingsAccount : ISavingsAccount
    {
        public CitiSavingsAccount()
        {
            Balance = 5000;
        }
    }

    //concrete product
    public class NationalSavingsAccount : ISavingsAccount
    {
        public NationalSavingsAccount()
        {
            Balance = 10000;
        }
    }

    //Creator
    interface ICreditUnionFactory
    {
        ISavingsAccount GetSavingsAccount(string acctNO);
    }

    //Concrete creator
    public class SavingsAccountFactory : ICreditUnionFactory
    {
        public ISavingsAccount GetSavingsAccount(string acctNO)
        {
            if (acctNO.Contains("CITI"))
            {
                return new CitiSavingsAccount();
            }
            else if (acctNO.Contains("NATIONAL"))
            {
                return new NationalSavingsAccount();
            }
            else
            {
                throw new ArgumentException("invalid account number");
            }
        }
    }

}
