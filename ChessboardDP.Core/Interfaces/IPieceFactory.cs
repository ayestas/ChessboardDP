using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessboardDP.Core.Models;
using ChessboardDP.Core.Pieces;

namespace ChessboardDP.Core.Interfaces
{
    public interface IPieceFactory
    {
        Piece Create(PiecePolicy policy);
    }
}
