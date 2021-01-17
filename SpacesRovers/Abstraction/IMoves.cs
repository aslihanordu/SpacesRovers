using SpacesRovers.Models;

namespace SpacesRovers.Moves
{
    public interface IMoves
    {
        Direction FindDirectionL(Direction direction);
        Direction FindDirectionR(Direction direction);
        Position Move(Position _position);
    }
}