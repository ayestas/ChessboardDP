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

        public PieceEngine(ITypeReader reader, IPieceFactory factory)
        {
            _reader = reader;
            _factory = factory;
        }

        public void ChoosePiece()
        {
            string pice = _reader.Read();
            Console.WriteLine(pice)
        }
    }
}
