using mars_rover_case.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mars_rover_case.Models
{

    public class Plateau : IPlateau
    {
        int _minWidth;
        int _width;
        int _minHeight;
        int _height;

        public Plateau(int Width, int Height)
        {
            _width = Width;
            _height = Height;
        }


        public int MinWidth { get { return _minWidth; } set { _minWidth = value; } }

        public int MinHeight { get { return _minHeight; } set { _minHeight = value; } }

        public int Width { get { return _width; } set { _width = value; } }

        public int Height { get { return _height; } set { _height = value; } }

    }
}
