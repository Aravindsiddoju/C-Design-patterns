using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Context
{
    public class ContextClass
    {
        public ContextClass(string roman)
        {
            Input = roman;
        }
        public string Input { get; set; }

        public int Output { get; set; }
    }
}
