using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessConsole.Pieces
{
    public abstract class Piece
    {
        public Color Color { get; set; }
        public Coordinates Coordinates { get; set; }
        public abstract char Char { get; }

        public Piece(Coordinates coordinates, Color color)
        {
            Coordinates = coordinates;
            Color = color;
        }
    }
}
