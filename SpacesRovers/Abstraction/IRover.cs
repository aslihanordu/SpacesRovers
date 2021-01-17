using SpacesRovers.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpacesRovers.Abstraction
{
    public interface IRover
    {
        IEnumerable<string> MoveList { get; set; }
        Position Position { get; set; }
    }
}
