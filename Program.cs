using System;
using System.Drawing;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map(5,5);
            Rover rover = new Rover(new Point(1,2),Direction.N);
            rover.CommandSet = "LMLMLMLMM";
            Console.WriteLine(rover.StartExplore());

            rover = new Rover(new Point(3,3), Direction.E);
            rover.CommandSet = "MMRMMRMRRM";
            Console.WriteLine(rover.StartExplore());
        }
    }
}
