using MarsRover.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Commands
{
    public abstract class TurnCommand : IRoverCommand
    {
        public bool IsExecutable(IRover target)
        {
            return true;
        }

        public abstract void Execute(IRover target);
    }
}
