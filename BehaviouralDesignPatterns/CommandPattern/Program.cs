using CommandPattern.Command;
using CommandPattern.ConcreteCommand;
using CommandPattern.Invoker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            ICommand _add1 = new AddCommand(2, 3);
            user.ExecuteCommand(_add1);
            ICommand _subtract1 = new SubtractCommand(3, 2);
            user.ExecuteCommand(_subtract1);
            user.Undo();
            user.Redo();
        }
    }
}
