using SpacesRovers.Abstraction;
using SpacesRovers.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SpacesRovers
{
    public class RoverCommand : IRoverCommand
    {
        List<IRover> roverList = new List<IRover>();
        private readonly TextReader input;
        public RoverCommand() : this(Console.In)
        {

        }
        public RoverCommand(TextReader input)
        {
            this.input = input;
        }
        public bool GetPlateau()
        {
            try
            {
                Position coords = new Position();
                string[] plateauCoords = input.ReadLine().Split(' ');
                coords.coordinates.X = Convert.ToInt32(plateauCoords[0]);
                coords.coordinates.Y = Convert.ToInt32(plateauCoords[1]);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool GetPositionsRover()
        {
            try
            {
                IRover rover = new Rover();
                string[] positionStr = input.ReadLine().Split(' ');
                rover.Position.coordinates.X = Convert.ToInt32(positionStr[0]);
                rover.Position.coordinates.Y = Convert.ToInt32(positionStr[1]);
                rover.Position.direction = Directions(positionStr[2]);
                rover.Position.Move = SpacePlateau.FindMove(rover.Position);
                rover.MoveList = GetMoveList(input.ReadLine(), rover);
                roverList.Add(rover);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public Direction Directions(string direction)
        {
            switch (direction)
            {
                case "N":
                    return Direction.N;
                case "E":
                    return Direction.E;
                case "W":
                    return Direction.W;
                case "S":
                    return Direction.S;
                default:
                    return Direction.N;
            }
        }
        public IEnumerable<string> GetMoveList(string move, IRover _rover)
        {
            List<string> moveList = new List<string>();
            SpacesRovers.Moves.Moves m = new SpacesRovers.Moves.Moves();
            foreach (var item in move)
            {
                if (item == 'L')
                {
                    var direction = m.FindDirectionL(_rover.Position.direction);
                    _rover.Position.direction = direction;
                    moveList.Add(item.ToString());
                }
                else if (item == 'R')
                {
                    var direction = m.FindDirectionR(_rover.Position.direction);
                    _rover.Position.direction = direction;
                    moveList.Add(item.ToString());
                }
                else if (item == 'M')
                {
                    m.Move(_rover.Position);
                    moveList.Add(item.ToString());
                }
            }
            return moveList;
        }
        public string GetOutput()
        {
            foreach (var item in roverList)
            {
                Console.WriteLine(item.Position.coordinates.X + " " + item.Position.coordinates.Y + " " + item.Position.direction);
            }
            return "output was written to the console";

        }
    }
}
