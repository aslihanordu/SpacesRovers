using SpacesRovers.Abstraction;
using SpacesRovers.Models;
using System.Collections.Generic;

namespace SpacesRovers
{
    public interface IRoverCommand
    {
        bool GetPlateau();
        bool GetPositionsRover();
        string GetOutput();
    }
}