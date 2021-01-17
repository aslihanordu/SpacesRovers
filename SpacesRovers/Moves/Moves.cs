using SpacesRovers.Abstraction;
using SpacesRovers.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpacesRovers.Moves
{
    public class Moves : IMoves
    {
        public Direction FindDirectionL(Direction direction)
        {
            if (direction == Direction.S)
            {
                direction = Direction.E;
            }
            else
            {
                direction -= 1;
            }
            return direction;
        }
        public Direction FindDirectionR(Direction direction)
        {
            IRover add = new Rover();
            if (direction == Direction.E)
            {
                direction = Direction.S;
                add.Position.direction = direction;
            }
            else
            {
                direction += 1;
                add.Position.direction = direction;
            }
            return add.Position.direction;
        }
        public Position Move(Position _position)
        {
            if (_position.direction == Direction.E)
            {
                _position.coordinates.X = _position.coordinates.X + _position.Move;
            }
            else if (_position.direction == Direction.W)
            {
                _position.coordinates.X = _position.coordinates.X - _position.Move;
            }
            else if (_position.direction == Direction.N)
            {
                _position.coordinates.Y = _position.coordinates.Y + _position.Move;
            }
            else
            {
                _position.coordinates.Y = _position.coordinates.Y - _position.Move;
            }
            return _position;
        }
    }
}
