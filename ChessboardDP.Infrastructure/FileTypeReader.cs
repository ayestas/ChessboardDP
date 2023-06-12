using ChessboardDP.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessboardDP.Infrastructure
{
    public class FileTypeReader : ITypeReader
    {
        public string Read() => File.ReadAllText("moves.txt");
    }
}
