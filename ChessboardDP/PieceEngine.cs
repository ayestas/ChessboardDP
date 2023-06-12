using ChessboardDP.Core.Board;
using ChessboardDP.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessboardDP.App
{
    public class PieceEngine
    {
        private readonly ITypeReader _reader;
        private readonly IPieceFactory _factory;
        private readonly IToPolicy _policy;

        public PieceEngine(ITypeReader reader, IPieceFactory factory, IToPolicy policy)
        {
            _reader = reader;
            _factory = factory;
            _policy = policy;
        }

        public Core.Pieces.Piece ChoosePiece()
        {
            string piece = _reader.Read();
            var policy = _policy.toPolicy(piece);

            var finalPiece = _factory.Create(policy);

            Board b = new Board(8);

            Cell celda = b.setCurrentCell(2, 2);
            celda.Occupied = true;

            Console.WriteLine();

            finalPiece.Movement(policy, b.Grid, celda);
            b.printBoard();

            return finalPiece;
        }
    }
}
