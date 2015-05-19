using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Commands
{
    public class CommandFactory
    {
        public IRoverCommand GetCommand(char c)
        {
            switch(c)
            {
                case 'f': return new MoveForwardCommand();
                case 'b': return new MoveBackwardCommand();
                case 'l': return new TurnLeftCommand();
                case 'r': return new TurnRightCommand();
                default: throw new ArgumentException("unknown command: " + c);
            }
        }

        public IList<IRoverCommand> GetCommand(string commands)
        {
            var list = new List<IRoverCommand>();
            foreach(var c in commands)
            {
                var cmd = GetCommand(c);
                list.Add(cmd);
            }
            return list;
        }
    }
}
