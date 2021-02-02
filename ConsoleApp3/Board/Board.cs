using System;
using Board;

namespace Board
{
    class GameBoard
    {
        public int rows { get; set; }
        public int columns { get; set; }
        private Pieces[,] pieces;

        public GameBoard(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            pieces = new Pieces[rows, columns];
        }

        public Pieces piece(int row, int column)
        {
            return pieces[row, column];
        }

        public Pieces piece(Position pos)
        {
            return pieces[pos.row, pos.column];
        }

        public bool pieceExists(Position pos)
        {
            validatePosition(pos);
            return piece(pos) != null;
        }

        public void insertPiece(Pieces p, Position pos)
        {
            if (pieceExists(pos))
            {
                throw new BoardException("There is a piece on this position already!");
            }
            pieces[pos.row, pos.column] = p;
            p.position = pos;
        }

        public Pieces removePiece(Position pos)
        {
            if (piece(pos) == null)
            {
                return null;
            }
            else
            {
                Pieces aux = piece(pos);
                aux.position = null;
                pieces[pos.row, pos.column] = null;
                return aux;
            }
        }

        public bool validPosition(Position pos)
        {
            if (pos.row < 0 || pos.row >= rows || pos.column < 0 || pos.column >= columns)
            {
                return false;
            }
            return true;
        }
        public void validatePosition(Position pos)
        {
            if (!validPosition(pos))
            {
                throw new BoardException("Invalid Position!");
            }

        }
    } 
}
