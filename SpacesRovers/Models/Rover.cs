using SpacesRovers.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpacesRovers.Models
{
    public class Rover: IRover
    {
        public Position Position { get; set; }
        public IEnumerable<string> MoveList { get; set; }

        public Rover()
        {
            Position = new Position();
            MoveList = new List<string>();
        }
    }
}
