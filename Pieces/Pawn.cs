using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessConsole.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Coordinates coordinates, Color color) 
            : base(coordinates, color)
        {
        }

        public override char Char => '♙';

    }
}
