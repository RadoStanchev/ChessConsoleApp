using ChessConsole.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessConsole
{
    public class Board
    {
        public List<Piece> Pieces { get; set; }

        public Board() 
        {
            
        }

        private List<Piece> SetDefaultBoard()
        {
            var pieces = new List<Piece>();

            //White
            return pieces;
        }
    }
}
