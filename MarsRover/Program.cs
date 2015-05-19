using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctrl = new RoverController();
            ctrl.Execute("ffrffl");
            Console.WriteLine("Rover End Position (X={0}, Y={1})", ctrl.Rover.CurrentPosition.PosX, ctrl.Rover.CurrentPosition.PosY);
            Console.ReadKey();
        }
    }
}
