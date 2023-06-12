using ChessboardDP.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessboardDP.Core.Interfaces
{
    public interface IToPolicy
    {
        PiecePolicy? toPolicy(string policy);
    }
}
