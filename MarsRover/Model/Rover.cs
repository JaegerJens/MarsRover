using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Model
{
    public class Rover : IRover
    {
        public Rover(GridElement startPos, Direction startDir)
        {
            CurrentPosition = startPos;
            CurrentDirection = startDir;
        }

        public Direction CurrentDirection { get; set;}
        public GridElement CurrentPosition { get; set;}
    }
}
