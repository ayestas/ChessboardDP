using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessboardDP.Core.Board;
using ChessboardDP.Core.Interfaces;
using ChessboardDP.Core.Models;

namespace ChessboardDP.Core.Pieces
{
    public class Knight : Piece
    {

        public Knight() { }

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

            Grid[currentCell.Row + 2, currentCell.Col + 1].Validate = true;
            Grid[currentCell.Row + 2, currentCell.Col - 1].Validate = true;
            Grid[currentCell.Row - 2, currentCell.Col + 1].Validate = true;
            Grid[currentCell.Row - 2, currentCell.Col - 1].Validate = true;
            Grid[currentCell.Row + 1, currentCell.Col + 2].Validate = true;
            Grid[currentCell.Row + 1, currentCell.Col - 2].Validate = true;
            Grid[currentCell.Row - 1, currentCell.Col + 2].Validate = true;
            Grid[currentCell.Row - 1, currentCell.Col - 2].Validate = true;

            return Grid;

        }

    }
}
