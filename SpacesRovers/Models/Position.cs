using System;
using System.Collections.Generic;
using System.Text;

namespace SpacesRovers.Models
{
    public class Position
    {
        public Coordinates coordinates { get; set; }
        public Direction direction { get; set; }
        public int Move { get; set; }
        public Position()
        {
            coordinates = new Coordinates();
        }
    }
}
