using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Model
{
    public interface IRover
    {
        Direction CurrentDirection { get; set; }
        GridElement CurrentPosition { get; set; }
    }
}
