using mars_rover_case.Enums;
using mars_rover_case.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mars_rover_case.Command
{
    public static class RoverCommand
    {
        
        public static Direction Heading = Direction.N;

        public static void SetPosition(this Rover rover, int x, int y, Direction direction)
        {
            if (rover.Position == null)
            {
                rover.Position = new Position(x, y);
            }
            else
            {
                rover.Position.X = x;
                rover.Position.Y = y;
            }

            Heading = direction;
        }

        public static string CurrentPosition(this Rover rover)
        {
            return rover.Position.X + " " + rover.Position.Y + " " + GetHeading(rover);
        }

        public static Direction GetHeading(this Rover rover)
        {
            Direction direction;
            try
            {
                return Heading;
            }
            catch (Exception)
            {
                direction = Direction.N;
                Console.WriteLine("Direction error...");
            }

            return direction;
        }

        public static void Process(this Rover rover, string command)
        {
            for (int i = 0; i < command.Length; i++)
            {
                rover.RunCommand(command[i]);
            }
        }

        public static void RunCommand(this Rover rover, char command)
        {
            if ('L' == command)
                rover.TurnLeft();
            else if ('R' == command)
                rover.TurnRight();
            else if ('M' == command)
            {
                if (!rover.Move())
                    Console.WriteLine("Where are you trying to go?");
            }
            else
            {
                Console.WriteLine("Wrong parameters!..");
            }
        }

        public static bool Move(this Rover rover)
        {
            //Console.WriteLine(rover.plateau.IsMoveAvailable(rover.Position));
            if (!rover.Plateau.IsMoveAvailable(rover.Position))
            {
                return false;
            }
            // Console.WriteLine(rover.Heading);
            switch (Heading)
            {
                case Direction.N:
                    rover.Position.Y += 1;
                    break;
                case Direction.E:
                    rover.Position.X += 1;
                    break;
                case Direction.S:
                    rover.Position.Y -= 1;
                    break;
                case Direction.W:
                    rover.Position.X -= 1;
                    break;
            }

            return true;
        }

        public static void TurnLeft(this Rover rover)
        {
            Heading = ((int)Heading - 1) < (int)Direction.N ? Direction.W : (Direction)((int)Heading - 1);
        }

        public static void TurnRight(this Rover rover)
        {
            Heading = ((int)Heading + 1) > (int)Direction.W ? Direction.N : (Direction)((int)Heading + 1);
        }
    }
}
