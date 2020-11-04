using Interpreter.Context;
using Interpreter.Expression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            //create the context
            var roman = "MMXV";
            var context = new ContextClass(roman);

            //Building the parse tree
            var expressionTree = new List<ExpressionClass>
            {
                new ThousandExpression(),
                new HundredExpression(),
                new TenExpression(),
                new OneExpression(),            
            };

            //Interpret
            foreach (var expression in expressionTree)
            {
                expression.Interpret(context);
            }

            Console.WriteLine($"The decimal number is {context.Output}");

            Console.ReadKey();
        }
    }
}
