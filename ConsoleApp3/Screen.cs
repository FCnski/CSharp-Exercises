using System;
using Board;
using Board.enums;
using Chess;

namespace ChessGame
{
    class Screen
    {
        public static void PrintBoard(GameBoard brd)
        {
            for(int i=0; i < brd.rows; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < brd.columns; j++)
                {
                    printPiece(brd.piece(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void PrintBoard(GameBoard brd, bool[,] possiblePositions)
        {
            ConsoleColor OriginalBackground = Console.BackgroundColor;
            ConsoleColor AlteredBackground = ConsoleColor.DarkGray;

            for (int i = 0; i < brd.rows; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < brd.columns; j++)
                {
                    if(possiblePositions[i, j])
                    {
                        Console.BackgroundColor = AlteredBackground;
                    }
                    else
                    {
                        Console.BackgroundColor = OriginalBackground;
                    }
                    printPiece(brd.piece(i, j));
                    Console.BackgroundColor = OriginalBackground;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = OriginalBackground;
        }

        public static ChessPosition readChessPosition()
        {
            string s = Console.ReadLine();
            char column = s[0];
            int row = int.Parse(s[1] + "");
            return new ChessPosition(column, row);
        }
        public static void printPiece(Pieces piece)
        {
            if (piece == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (piece.color == Color.White)
                {
                    Console.Write(piece);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(piece);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }
    }
}
