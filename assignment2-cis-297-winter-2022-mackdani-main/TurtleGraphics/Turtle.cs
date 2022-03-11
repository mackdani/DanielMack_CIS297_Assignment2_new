using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleGraphics
{
    public class Turtle
    {
        public Turtle()
        {
            TurtleSymbol = 'N';
            PositionX = 0;
            PositionY = 0;
            Move = 0;
        }
        public char TurtleSymbol { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Move { get; set; }
        public void Movement(AllMovements.Directions moving, int spaces, Pen.PenActions pen)
        {
            if (CheckingtheMoves(moving, spaces))
            {
                var toDraw = (pen == Pen.PenActions.Down);
                switch (moving)
                {
                    case AllMovements.Directions.North:
                        if (toDraw)
                        {
                            GraphicBoard.UpdateGraphicBoardX(PositionX, -1, spaces, PositionY);
                        }
                        PositionX -= spaces;
                        break;
                    case AllMovements.Directions.South:
                        if (toDraw)
                        {
                            GraphicBoard.UpdateGraphicBoardX(PositionX, +1, spaces, PositionY);
                        }
                        PositionX += spaces;
                        break;
                    case AllMovements.Directions.West:
                        if (toDraw)
                        {
                            GraphicBoard.UpdateGraphicBoardY(PositionY, -1, spaces, PositionX);
                        }
                        PositionY -= spaces;
                        break;
                    case AllMovements.Directions.East:
                        if (toDraw)
                        {
                            GraphicBoard.UpdateGraphicBoardY(PositionY, +1, spaces, PositionX);
                        }
                        PositionY += spaces;
                        break;
                }
            }
        }
        private bool CheckingtheMoves(AllMovements.Directions movements, int spaces)
        {
            if(movements == AllMovements.Directions.North && (PositionX - spaces) < 0)
            {
                GameInstructions.MoveError(movements, PositionX);
                return false;
            }
            else if (movements == AllMovements.Directions.East && (PositionY + spaces) > GraphicBoard.GraphicBoardSize)
            {
                GameInstructions.MoveError(movements, GraphicBoard.GraphicBoardSize - PositionY - 1);
                return false;
            }
            else if (movements == AllMovements.Directions.South && (PositionX + spaces) > GraphicBoard.GraphicBoardSize)
            {
                GameInstructions.MoveError(movements, GraphicBoard.GraphicBoardSize - PositionX - 1);
                return false;
            }
            else if (movements == AllMovements.Directions.West && (PositionY - spaces) < 0)
            {
                GameInstructions.MoveError(movements, PositionY);
                return false;
            }
            return true;
        }
    }
}
