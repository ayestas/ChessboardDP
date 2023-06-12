using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessboardDP.Core.Board;

namespace ChessboardDP.Core.Interfaces
{
    public interface IBoard
    {
        void printBoard();
        Cell setCurrentCell(char r, char c);

    }
}
