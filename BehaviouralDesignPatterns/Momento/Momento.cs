using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Momento
{
    public class Momento
    {
        private string statement;

        public Momento(string statement)
        {
            this.statement = statement;
        }

        public string GetState()
        {
            return this.statement;
        }
    }
}
