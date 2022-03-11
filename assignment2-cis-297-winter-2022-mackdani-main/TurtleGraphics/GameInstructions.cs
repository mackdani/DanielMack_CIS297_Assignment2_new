using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleGraphics
{
    public static class GameInstructions
    {
        public static void Game_commands()
        {
            Console.WriteLine("1 - Pen up, 2 - Pen Down, 3 - North");
            Console.WriteLine("4 - East, 5 - South, 6 - West");
            Console.WriteLine("9 - Exit the Data");
        }
        public static string Message { get; set; }
        public static void InputError()
        {
            Message = "Error. Enter the Number from 1 to 7.";
        }
        public static void PenActionError()
        {
            Message = "Error. Enter the Number 1 for pen up or 2 for pen down.";
        }
        public static void DirectionError()
        {
            Message = "Error. Enter the Number 3 for Right or 4 for Left.";
        }
        public static void SpacesError()
        {
            Message = "Error. Enter the Number for Spaces.";
        }
        public static void MoveError(AllMovements.Directions movement, int spaces)
        {
            Message = String.Format("Error. You can only move {0} spaces to the {1}.", spaces, movement);
        }
    }
}
