using System;
using Board.enums;
using Board;
using Chess;

namespace ChessGame
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                GameBoard brd = new GameBoard(8, 8);



                brd.insertPiece(new Tower(brd, Color.Black), new Position(0, 0));
                brd.insertPiece(new Tower(brd, Color.Black), new Position(1, 8));
                brd.insertPiece(new King(brd, Color.Black), new Position(0, 3));

                Screen.PrintBoard(brd);

                Console.ReadLine();
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
