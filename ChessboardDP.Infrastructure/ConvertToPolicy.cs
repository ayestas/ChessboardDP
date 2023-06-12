using ChessboardDP.Core.Interfaces;
using ChessboardDP.Core.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ChessboardDP.Infrastructure
{
    public class ConvertToPolicy : IToPolicy
    {
        public PiecePolicy? toPolicy(string policy) => JsonConvert.DeserializeObject<PiecePolicy>(File.ReadAllText("moves.txt"),new StringEnumConverter());
    }
}
