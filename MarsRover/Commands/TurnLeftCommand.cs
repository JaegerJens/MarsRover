using MarsRover.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Commands
{
    public class TurnLeftCommand : TurnCommand
    {
        public override void Execute(IRover target)
        {
            target.CurrentDirection = target.CurrentDirection.TurnLeft();
        }
    }
}
