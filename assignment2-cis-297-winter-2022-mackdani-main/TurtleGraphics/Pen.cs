using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleGraphics
{
    public class Pen
    {
        private PenActions pen_actions;

        public Pen()
        {
            pen_actions = PenActions.Up;
        }
        public enum PenActions
        {
            Up = 1, 
            Down = 2
        };

        public PenActions pen_moving
        {
            get { return pen_actions; }
            set
            {
                switch ((int)value)
                {
                    case 1:
                        pen_actions = PenActions.Up;
                        break;
                    case 2:
                        pen_actions = PenActions.Down;
                        break;
                    default:
                        GameInstructions.PenActionError();
                        break;
                }
            }
        }
        public override string ToString()
        {
            return String.Format("Pen is {0}", pen_moving == PenActions.Up ? "Up" : "Down");
        }
    }
}
