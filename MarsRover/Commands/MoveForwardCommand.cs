using MarsRover.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Commands
{
    public class MoveForwardCommand : MoveCommand
    {
        public override void Execute(IRover target)
        {
            var nextPos = GetTargetPosition(target);
            target.CurrentPosition = nextPos;
        }
    }
}
