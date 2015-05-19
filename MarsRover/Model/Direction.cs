using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Direction
    {
        private readonly char _direction;

        public Direction(char direction)
        {
            _direction = direction;
        }

        public int dx
        {
            get
            {
                if (_direction == 'e')
                {
                    return 1;
                }
                if (_direction == 'w')
                {
                    return -1;
                }
                return 0;
            }
        }

        public int dy
        {
            get
            {
                if (_direction == 'n')
                {
                    return 1;
                }
                if (_direction == 's')
                {
                    return -1;
                }
                return 0;
            }
        }

        public Direction TurnLeft()
        {
            switch(_direction)
            {
                case 'n': return new Direction('w');
                case 'e': return new Direction('s');
                case 's': return new Direction('e');
                case 'w': return new Direction('n');
                default: throw new Exception("unknown direction: " + _direction);
            }
        }

        public Direction TurnRight()
        {
            switch (_direction)
            {
                case 'n': return new Direction('e');
                case 'e': return new Direction('n');
                case 's': return new Direction('w');
                case 'w': return new Direction('s');
                default: throw new Exception("unknown direction: " + _direction);
            }
        }
    }
}
