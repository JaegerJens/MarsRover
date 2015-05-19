using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Surface
    {
        private readonly int _size;

        public Surface(int size)
        {
            _size = size;
            Area = new GridElement[size, size];
            for(var x=0; x<size; x++)
            {
                for(var y=0; y<size; y++)
                {
                    Area[x, y] = new GridElement
                    {
                        PosX = x,
                        PosY = y,
                        IsTraversable = true,
                        Parent = this
                    };
                }
            }
        }

        public GridElement[,] Area { get; set; }

        public GridElement GetNeighbor(GridElement current, Direction dir)
        {
            var x1 = current.PosX + dir.dx;
            var y1 = current.PosY + dir.dy;

            if (x1<0)
            {
                x1 += _size;
            }
            if (x1>=_size)
            {
                x1 -= _size;
            }
            if (y1<0)
            {
                y1 += _size;
            }
            if (y1>=_size)
            {
                y1 -= _size;
            }

            return Area[x1, y1];
        }
    }
}
