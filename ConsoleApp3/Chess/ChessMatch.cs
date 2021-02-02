using System;
using Board;
using Board.enums;

namespace Chess
{
    class ChessMatch
    {
        public GameBoard brd { get; private set; }
        private int turn;
        private Color CurrentPlayer;
        public bool Finished { get; private set; }

        public ChessMatch()
        {
            brd = new GameBoard(8, 8);
            turn = 1;
            CurrentPlayer = Color.White;
            insertPieces();
        }

        public void executesMovement(Position origin, Position destiny)
        {
            Pieces p = brd.removePiece(origin);
            p.increaseAmountOfMovements();
            Pieces CapturedPiece = brd.removePiece(destiny);
            brd.insertPiece(p, destiny);
        }

        private void insertPieces()
        {
            brd.insertPiece(new Tower(brd, Color.White), new ChessPosition('c', 1).toPosition());
            brd.insertPiece(new Tower(brd, Color.White), new ChessPosition('c', 2).toPosition());
            brd.insertPiece(new Tower(brd, Color.White), new ChessPosition('d', 2).toPosition());
            brd.insertPiece(new Tower(brd, Color.White), new ChessPosition('e', 2).toPosition());
            brd.insertPiece(new Tower(brd, Color.White), new ChessPosition('e', 1).toPosition());
            brd.insertPiece(new King(brd, Color.White), new ChessPosition('d', 1).toPosition());

            brd.insertPiece(new Tower(brd, Color.Black), new ChessPosition('c', 7).toPosition());
            brd.insertPiece(new Tower(brd, Color.Black), new ChessPosition('c', 8).toPosition());
            brd.insertPiece(new Tower(brd, Color.Black), new ChessPosition('d', 7).toPosition());
            brd.insertPiece(new Tower(brd, Color.Black), new ChessPosition('e', 7).toPosition());
            brd.insertPiece(new Tower(brd, Color.Black), new ChessPosition('e', 8).toPosition());
            brd.insertPiece(new King(brd, Color.Black), new ChessPosition('d', 8).toPosition());
        }

    }
}
