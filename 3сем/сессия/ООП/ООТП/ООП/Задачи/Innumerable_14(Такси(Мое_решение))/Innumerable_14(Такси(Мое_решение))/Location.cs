using System;
using System.Collections.Generic;
using System.Text;

namespace Innumerable_14_Такси_Мое_решение__
{
    class Location
    {
        public int Lat { get; set; }
        public int Long { get; set; }
        public int Speed { get; set; }
    public Location (int lat, int longe, int speed)
        {
            Lat = lat;
            Long = longe;
            Speed = speed;
        }
    }
}
