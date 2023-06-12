using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessboardDP.Core.Interfaces;
using ChessboardDP.Core.Models;

namespace ChessboardDP.Core.Pieces
{
    public class PieceFactory : IPieceFactory
    {
        public Piece Create(PiecePolicy policy)
        {
            try
            {
                var type = Type.GetType($"ChessboardDP.Core.Pieces.{policy.Type}");

                return (Piece)Activator.CreateInstance(type);
            }
            catch (Exception ex)
            {
                return new Knight();
            }
        }
    }
}
