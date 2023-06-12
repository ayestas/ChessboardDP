using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessboardDP.Core.Models
{
    public enum PieceType
    {
        Knight = 'C',
        Rook = 'T',
        Pawn = 'P',
    }
    public class PiecePolicy
    {
        public PieceType Type { get; set; }
        public int Size { get; set; }
    }
}
