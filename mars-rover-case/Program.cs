using mars_rover_case.Command;
using mars_rover_case.Enums;
using mars_rover_case.Models;
using System;

namespace mars_rover_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Plateau plateau = new(5, 5);
            Position position = new(1, 2);

            // Create rover instance
            Rover rover = new(plateau, position, Direction.N);
            rover.Process("LMLMLMLMM");
            Console.WriteLine(rover.CurrentPosition()); // prints 1 3 N


            rover.SetPosition(3, 3, Direction.E);
            rover.Process("MMRMMRMRRM");
            Console.WriteLine(rover.CurrentPosition()); // prints 5 1 E


            Console.ReadLine();
        }
    }
}
