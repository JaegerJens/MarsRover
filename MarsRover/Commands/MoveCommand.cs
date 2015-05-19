using MarsRover.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Commands
{
    public abstract class MoveCommand : IRoverCommand
    {
        public GridElement CurrentPosition { get; set; }
        public GridElement TargetPosition { get; set; }
        public Direction MoveDirection { get; protected set; }

        public bool IsExecutable(IRover rover)
        {
            var possibleTarget = GetTargetPosition(rover);
            return possibleTarget.IsTraversable;
        }

        protected GridElement GetTargetPosition(IRover rover)
        {
            CurrentPosition = rover.CurrentPosition;
            MoveDirection = rover.CurrentDirection;

            var world = CurrentPosition.Parent;
            return world.GetNeighbor(CurrentPosition, MoveDirection);
        }

        public abstract void Execute(IRover target);
    }
}
