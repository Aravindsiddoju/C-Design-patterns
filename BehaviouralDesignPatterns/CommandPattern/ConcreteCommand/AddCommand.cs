using CommandPattern.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.ConcreteCommand
{
    public class AddCommand : ICommand
    {
        private int _a;
        private int _b;

        public AddCommand(int a, int b)
        {
            _a = a;
            _b = b;
        }
        public void Execute()
        {
            Console.WriteLine($"The value after executing the command is {_a + _b}");
        }

    }
}
