using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.ClientRequest
{
    public class Purchase
    {
        private int _purchaseId;
        private int _purchaseAmount;
        private string _purpose;

        public Purchase(int purchaseId, int purchaseAmount, string purpose)
        {
            this._purchaseId = purchaseId;
            this._purchaseAmount = purchaseAmount;
            this._purpose = purpose;
        }

        public int Id
        {
            get { return _purchaseId; }
            set { _purchaseId = value; }
        }

        public int Amount
        {
            get { return _purchaseAmount; }
            set { _purchaseAmount = value; }
        }


        public string Purpose
        {
            get { return _purpose; }
            set { _purpose = value; }
        }

    }
}
