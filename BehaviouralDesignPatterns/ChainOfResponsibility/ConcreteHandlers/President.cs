using ChainOfResponsibility.ClientRequest;
using ChainOfResponsibility.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.ConcreteHandlers
{
    public class President : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 5000)
            {
                Console.WriteLine($"The purchase with Id:{purchase.Id} is approved by the {this.GetType().Name}");
            }
            else if (_successor != null)
            {
                _successor.ProcessRequest(purchase);
            }
            else
            {
                Console.WriteLine("Your purchase approval was denied.");
            }
        }
    }
}
