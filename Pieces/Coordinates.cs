using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessConsole.Pieces
{
    public class Coordinates
    {
        public Coordinates(File file,int rank)
        {
            Rank = rank;
            File = file;
        }

        public int Rank { get; set; }

        public File File { get; set; }
    }
}
