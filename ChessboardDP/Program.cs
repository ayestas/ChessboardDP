using ChessboardDP.App;
using ChessboardDP.Core.Board;
using ChessboardDP.Core.Pieces;
using ChessboardDP.Infrastructure;

Board b = new Board(8);

/*
Knight k = new Knight();

Cell celda = b.setCurrentCell(2, 2);
celda.Occupied = true;

Console.WriteLine();

k.Movement(b.Grid, celda);

Cell newCelda = b.setCurrentCell(3, 4);
newCelda.Occupied = true;

if(k.PlaceNextMove(newCelda) == true)
{
    k.Movement(b.Grid, newCelda);
    b.printBoard();
}
*/

var engine = new PieceEngine(new FileTypeReader(), new PieceFactory(), new ConvertToPolicy());
var p = engine.ChoosePiece();


Console.ReadLine();
