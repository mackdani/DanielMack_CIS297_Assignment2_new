using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleGraphics
{
    public class GraphicGame
    {
        private int Choices;
        private Pen VirtualPen;
        private Turtle turtle;
        private bool Exit;
        private GraphicBoard Game_Board;
        public GraphicGame()
        {
            VirtualPen = new Pen();
            turtle = new Turtle();
            Game_Board = new GraphicBoard();
            Exit = false;
        }
        public void GameRunning()
        {
            do
            {
            Console.Clear();
            Console.WriteLine(GameInstructions.Message);
            GameInstructions.Message = "";
            Game_Board.DrawGraphicBoard(turtle.PositionX, turtle.PositionY, turtle.TurtleSymbol);
            GameInstructions.Game_commands();
            Console.WriteLine(VirtualPen);
            Console.WriteLine("Select your Choices:");
            if(int.TryParse(Console.ReadLine(), out Choices))
            {
            if (Choices > 0 && Choices < 3)
              {
                        VirtualPen.pen_moving = (Pen.PenActions) Choices;
              }
            else if (Choices > 2 && Choices < 7)
              {
              var moving = (AllMovements.Directions) Choices;
              Console.WriteLine("Turtle is moving {0}", moving);
              Console.WriteLine("Enter a number of spaces to move: ");
              int spaces;
                if(int.TryParse(Console.ReadLine(), out spaces))
                {
                turtle.Movement(moving, spaces, VirtualPen.pen_moving);
                }
                else
                {
                GameInstructions.InputError();              
                }
              }
             else if (Choices == 9)
             {
             Exit = true;
             }
            }
            else
            {
            GameInstructions.InputError();
            }
            } while (!Exit);
        }
    }
}
