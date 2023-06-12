using ChessboardDP.App;
using ChessboardDP.Core.Board;
using ChessboardDP.Core.Pieces;
using ChessboardDP.Infrastructure;



var engine = new PieceEngine(new FileTypeReader(), new PieceFactory(), new ConvertToPolicy());
engine.ChoosePiece();


Console.ReadLine();
