using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mars_rover_case.Interfaces
{
    interface IPlateau
    {
        public int MinWidth { get; set; }
        public int Width { get; set; }
        public int MinHeight { get; set; }
        public int Height { get; set; }
    }
}
