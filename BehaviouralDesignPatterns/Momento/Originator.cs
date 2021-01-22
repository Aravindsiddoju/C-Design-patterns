using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Momento
{
    public class Originator
    {
        private string statement;

        public void Set(string newStatement)
        {
            Console.WriteLine("----");
            Console.WriteLine("From Originator: Current Version of Statement\n"
                + newStatement + "\n");
            this.statement = newStatement;
        }

        public Momento StoreInMomento()
        {
            Console.WriteLine("From Originator: Saving to Memento");
            return new Momento(this.statement);
        }

        public string RestoreFromMomento(Momento momento)
        {
            this.statement = momento.GetState();
            Console.WriteLine("From Originator: Previous Statement Saved in Memento\n" + statement + "\n");

            return this.statement;
        }
    }
}
