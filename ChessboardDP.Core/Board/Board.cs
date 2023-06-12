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

        public Cell setCurrentCell(char r, char c)
        {
            int row = RowNumber(r);
            int col = ColNumber(c);
            return Grid[row, col];
        }

        int ColNumber(char c)
        {
            if (c == 'a')
                return 0;
            else if (c == 'b')
                return 1;
            else if (c == 'c')
                return 2;
            else if (c == 'd')
                return 3;
            else if (c == 'e')
                return 4;
            else if (c == 'f')
                return 5;
            else if (c == 'g')
                return 6;
            else if (c == 'h')
                return 7;
            else
            {
                Console.WriteLine("La columna " + c + " no existe, se asigna el default (c).");
                return 2;
            }
        }

        int RowNumber(char c)
        {
            if (c == '1')
                return 0;
            else if (c == '2')
                return 1;
            else if (c == '3')
                return 2;
            else if (c == '4')
                return 3;
            else if (c == '5')
                return 4;
            else if (c == '6')
                return 5;
            else if (c == '7')
                return 6;
            else if (c == '8')
                return 7;
            else
            {
                Console.WriteLine("La fila " + c + " no existe, se asigna el default (3).");
                return 2;
            }
        }

    }
}
