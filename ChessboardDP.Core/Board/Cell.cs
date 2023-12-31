﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessboardDP.Core.Board
{
    public class Cell
    {
        public int Row { get; set; }
        public int Col { get; set; }

        public bool Occupied { get; set; }
        public bool Validate { get; set; }

        public Cell(int x, int y)
        {
            Row = x;
            Col = y;
        }
    }
}
