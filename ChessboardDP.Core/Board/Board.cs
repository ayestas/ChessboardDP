using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessboardDP.Core.Interfaces;

namespace ChessboardDP.Core.Board
{
    public class Board : IBoard
    {
        public int Size { get; set; }
        public Cell[,] Grid { get; set; }

        public Board(int x)
        {
            Size = x;

            Grid = new Cell[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Grid[i, j] = new Cell(i, j);
                }
            }
        }

        public void printBoard()
        {
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine("+---+---+---+---+---+---+---+---+");
                for (int j = 0; j < Size; j++)
                {
                    Cell c = Grid[i, j];
                    Console.Write("| ");

                    if (c.Occupied == true)
                    {
                        Console.Write("X");
                    }
                    else if (c.Validate == true)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("+---+---+---+---+---+---+---+---+");
        }

        public Cell setCurrentCell(int r, int c)
        {
            return Grid[r, c];
        }
    }
}
