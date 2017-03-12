using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities

{
    public class Coordinates
    {
        public int x { get; private set; }
        public int y { get; private set; }

        public Coordinates(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
    }
}
