using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleGraphics
{
    public class GraphicBoard
    {
        public const int GraphicBoardSize = 20;
        public const char UsedSpace = 'O';
        public const char BoardSymbol = '*';
        public GraphicBoard()
        {
            GraphicBoardArray = new char[GraphicBoardSize, GraphicBoardSize];
            GameBoardSetup();
        }
        public static char[,] GraphicBoardArray { get; set; }

        public void GameBoardSetup()
        {
            for (int x = 0; x < GraphicBoardSize; x++)
            {
                for (int y = 0; y < GraphicBoardSize; y++)
                {
                    GraphicBoardArray[x, y] = BoardSymbol;
                }
            }
        }
        public void DrawGraphicBoard(int PosX, int PosY, char turtle)
        {
        for(int x = 0;x < GraphicBoardSize; x++)
            {
                for(int y = 0; y < GraphicBoardSize; y++)
                {
                if(x == PosX && y == PosY)
                {
                   Console.Write(turtle);
                }
                else
                {
                   Console.Write(GraphicBoardArray[x, y]);
                }
                }
                Console.WriteLine();
            }
        }
        public static void UpdateGraphicBoardX(int start, int adding, int counting, int constant)
        {
            for (int x = 0; x < counting; x++)
            {
                GraphicBoardArray[start + (x * adding), constant] = UsedSpace;
            }
        }
        public static void UpdateGraphicBoardY(int start, int adding, int counting, int constant)
        {
            for (int x = 0; x < counting; x++)
            {
                GraphicBoardArray[constant, start + (x * adding)] = UsedSpace;
            }
        }
    }
}