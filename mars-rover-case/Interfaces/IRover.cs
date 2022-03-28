using mars_rover_case.Enums;
using mars_rover_case.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mars_rover_case.Interfaces
{
    public interface IRover
    {
        Plateau Plateau { get; set; }

        Position Position { get; set; }

        Direction Direction { get; set; }
    }
}
