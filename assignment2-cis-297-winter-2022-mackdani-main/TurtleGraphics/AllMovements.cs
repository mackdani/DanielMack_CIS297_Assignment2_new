using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleGraphics
{
    public static class AllMovements
    {
        private static Directions MoveDirection;
        public enum Directions
        {
            North = 3, East = 4, South = 5, West = 6
        };
        public static Directions Direction
        {
            get { return MoveDirection; }
            set
            {
                switch ((int)value)
                {
                    case 3:
                        MoveDirection = Directions.North;
                        break;
                    case 4:
                        MoveDirection = Directions.East;
                        break;
                    case 5:
                        MoveDirection = Directions.South;
                        break;
                    case 6:
                        MoveDirection = Directions.West;
                        break;
                    default:
                        GameInstructions.DirectionError();
                        break;
                }
            }
        }
    }
}
