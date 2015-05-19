using MarsRover.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Commands
{
    public interface IRoverCommand
    {
        void Execute(IRover target);

        bool IsExecutable(IRover target);
    }
}
