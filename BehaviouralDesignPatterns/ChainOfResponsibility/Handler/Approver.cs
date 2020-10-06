using ChainOfResponsibility.ClientRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handler
{
    /// <summary>
    /// abstract Handler class.
    /// All the concrete handlers will inherit from this abstract class.
    /// </summary>
    public abstract class Approver
    {
        protected Approver _successor;

        public void AddSuccesor(Approver successor)
        {
            this._successor = successor;
        }

        public abstract void ProcessRequest(Purchase purchase);
    }
}
