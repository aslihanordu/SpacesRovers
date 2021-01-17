using System;
using System.Collections.Generic;
using System.Text;

namespace SpacesRovers.Models
{
    public class SpacePlateau
    {
        public static int FindMove(Position position)
        {
            switch (position.direction)
            {
                case Direction.E:
                case Direction.N:
                    {
                        position.Move = 1;
                    }
                    break;
                case Direction.S:
                case Direction.W:
                    {
                        position.Move = -1;
                    }
                    break;
            }

            return position.Move;
        }
    }
}
