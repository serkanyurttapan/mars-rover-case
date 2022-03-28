using mars_rover_case.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mars_rover_case.Command
{
    public static class PlateauCommand
    {
        public static bool IsMoveAvailable(this Plateau plateau, Position position)
        {
            return plateau.MinWidth <= position.X && position.X <= plateau.Width && plateau.MinHeight <= position.Y && position.Y <= plateau.Height;
        }
    }
}
