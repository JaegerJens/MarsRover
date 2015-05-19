using MarsRover.Commands;
using MarsRover.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class RoverController
    {
        private readonly CommandFactory _controller;

        public RoverController()
        {
            _controller = new CommandFactory();
            World = new Surface(100);
            Rover = new Rover(World.Area[0, 0], new Direction('n'));
        }

        public IRover Rover { get; set; }
        public Surface World { get; set; }

        public void Execute(string commandList)
        {
            var plan = _controller.GetCommand(commandList);
            foreach(var step in plan)
            {
                if (!step.IsExecutable(Rover))
                {
                    throw new Exception("current step is not executable");
                }
                step.Execute(Rover);
            }
        }
    }
}
