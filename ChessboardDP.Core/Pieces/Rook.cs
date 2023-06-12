using ChessboardDP.Core.Board;
using ChessboardDP.Core.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessboardDP.Core.Pieces
{
    public class Rook : Piece
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

            for (int i = 1; i <= p.Size; i++)
            {
                Grid[currentCell.Row - i, currentCell.Col].Validate = true;
            }
            for (int i = 0; i < p.Size; i++)
            {
                Grid[currentCell.Row + i, currentCell.Col].Validate = true;
            }
            for (int i = 0; i < p.Size; i++)
            {
                Grid[currentCell.Row, currentCell.Col - i].Validate = true;
            }
            for (int i = 0; i < p.Size; i++)
            {
                Grid[currentCell.Row, currentCell.Col + i].Validate = true;
            }

            return Grid;
        }
    }
}
