using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessboardDP.Core.Board;
using ChessboardDP.Core.Interfaces;

namespace ChessboardDP.Core.Pieces
{
    public abstract class Piece
    {
        public int Size { get; set; }

        public abstract Cell[,] Movement(Cell[,] Grid, Cell currentCell);

        public virtual bool PlaceNextMove(Cell newCell)
        {
            if (newCell.Validate == false)
            {
                Console.WriteLine("Movimiento no permitido para la pieza.");
                return false;
            }

            else
            {
                Console.WriteLine("Movimiento permitido");
                return true;
            }
        }


    }
}
