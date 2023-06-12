using ChessboardDP.Core.Board;
using ChessboardDP.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessboardDP.Core.Pieces
{
    public class Pawn : Piece
    {
        public override Cell[,] Movement(PiecePolicy p, Cell[,] Grid, Cell currentCell)
        {
            for (int i = 0; i < p.Size; i++)
            {
                for (int j = 0; j < p.Size; j++)
                {
                    Grid[i, j].Validate = false;
                    Grid[i, j].Occupied = false;
                }
            }

            Grid[currentCell.Row + 1, currentCell.Col].Validate = true;
            Grid[currentCell.Row + 2, currentCell.Col].Validate = true;

            return Grid;
        }
    }
}
