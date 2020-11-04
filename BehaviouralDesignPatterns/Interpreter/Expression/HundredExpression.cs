﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Expression
{
    public class HundredExpression : ExpressionClass
    {
        public override string Five()
        {
            return "D";
        }

        public override string Four()
        {
            return "CD";
        }

        public override int Multiplier()
        {
            return 100;
        }

        public override string Nine()
        {
            return "CM";
        }

        public override string One()
        {
            return "C";
        }
    }
}
