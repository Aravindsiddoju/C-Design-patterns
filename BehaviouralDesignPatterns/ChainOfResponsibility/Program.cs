using ChainOfResponsibility.ClientRequest;
using ChainOfResponsibility.ConcreteHandlers;
using ChainOfResponsibility.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // Client code.

            //Intitialize different approvers.
            Approver manager = new Manager();
            Approver vicePresident = new VicePresident();
            Approver president = new President();

            // Set the chain of responsibility.
            manager.AddSuccesor(vicePresident);
            vicePresident.AddSuccesor(president);

            // Generate and process purchase requests.
            Purchase purchase_1 = new Purchase(5230, 2500, "Desk");
            manager.ProcessRequest(purchase_1);

            Purchase purchase_2 = new Purchase(2200, 990, "Mouse");
            manager.ProcessRequest(purchase_2);

            Purchase purchase_3 = new Purchase(3219, 1990, "keyboard");
            manager.ProcessRequest(purchase_3);

            Purchase purchase_4 = new Purchase(3219, 10000, "CPU");
            manager.ProcessRequest(purchase_4);

        }
    }
}
