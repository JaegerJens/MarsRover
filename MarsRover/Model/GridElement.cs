using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class GridElement
    {
        public bool IsTraversable { get; set; }

        public int PosX { get; set; }
        public int PosY { get; set; }

        public Surface Parent { get; set; }
    }
}
