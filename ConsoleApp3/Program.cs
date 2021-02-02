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
                ChessMatch match = new ChessMatch();

                while (!match.Finished)
                {
                    Console.Clear();
                    Screen.PrintBoard(match.brd);

                    Console.WriteLine("");
                    Console.Write("Origin: ");
                    Position origin = Screen.readChessPosition().toPosition();

                    bool[,] possiblePositions = match.brd.piece(origin).possibleMovements();

                    Console.Clear();
                    Screen.PrintBoard(match.brd, possiblePositions);

                    Console.WriteLine("");
                    Console.Write("Destiny: ");
                    Position destiny = Screen.readChessPosition().toPosition();

                    match.executesMovement(origin, destiny);
                }

                Screen.PrintBoard(match.brd);

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
