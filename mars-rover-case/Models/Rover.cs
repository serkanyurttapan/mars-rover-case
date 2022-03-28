using mars_rover_case.Command;
using mars_rover_case.Enums;
using mars_rover_case.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mars_rover_case.Models
{
    public class Rover : IRover
    {

        private Plateau _plateau;
        private Position _position;
        private Direction _heading = RoverCommand.Heading;

        public Rover(Plateau plateau, Position position, Direction heading)
        {
            _plateau = plateau;
            _position = position;
            _heading = heading;
        }

        public Plateau Plateau { get { return _plateau; } set { _plateau = value; } }

        public Position Position { get { return _position; } set { _position = value; } }

        public Direction Direction { get { return _heading; } set { _heading = value; } }
    }
}
