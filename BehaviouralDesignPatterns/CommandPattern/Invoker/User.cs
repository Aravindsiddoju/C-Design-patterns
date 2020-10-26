using CommandPattern.Command;
using CommandPattern.ConcreteCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Invoker
{
    public class User
    {
        private ICommand _addCommand;
        private ICommand _subtractCommand;
        private Stack<ICommand> _stack1;
        private Stack<ICommand> _stack2;

        public User()
        {
            _stack1 = new Stack<ICommand>();
            _stack2 = new Stack<ICommand>();
            Console.WriteLine($"The initial value is {0}.");
        }

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _stack2.Push(command);
        }

        public void Undo()
        {
            if(_stack2.Count == 0)
            {
                Console.WriteLine($"There isn't any command left for undo operation");
                return;
            }
            ICommand recentlyExeceutedCommand = _stack2.Pop();
            _stack1.Push(recentlyExeceutedCommand);
            if (_stack2.Count == 0)
            {
                Console.WriteLine($"The value after executing this command is {0}.");
                return;
            }
            ICommand command = _stack2.Pop();
            Console.WriteLine("Executing the undo operation.");
            command.Execute();
        }

        public void Redo()
        {
            if (_stack1.Count == 0)
            {
                Console.WriteLine($"There isn't any command left for undo operation");
                return;
            }
            ICommand command = _stack1.Pop();
            Console.WriteLine("Executing the redo operation.");
            command.Execute();

        }

    }
}
