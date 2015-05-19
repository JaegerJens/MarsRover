using MarsRover.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Commands
{
    public class MoveBackwardCommand : MoveCommand
    {
        public override void Execute(IRover target)
        {
            // turn 180° around
            var dir = target.CurrentDirection;
            MoveDirection = dir.TurnLeft().TurnLeft();
            target.CurrentDirection = MoveDirection;

            // move one step forward
            var nextPos = GetTargetPosition(target);
            target.CurrentPosition = nextPos;
        }
    }
}
