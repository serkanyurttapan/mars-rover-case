using mars_rover_case.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mars_rover_case.Models
{
    public class Position : IPosition
    {
        int _x;
        int _y;
        public Position(int X, int Y)
        {
            _x = X;
            _y = Y;
        }

        public int X { get { return _x; } set { _x = value; } }
        public int Y { get { return _y; } set { _y = value; } }
    }
}
