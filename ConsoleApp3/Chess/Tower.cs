using System;
using Board;
using Board.enums;
using Chess;

namespace Chess
{
    class Tower : Pieces
    {
        public Tower(GameBoard brd, Color color) : base(brd, color)
        {

        }
        public override bool[,] possibleMovements()
        {
            bool[,] mat = new bool[brd.rows, brd.columns];

            Position pos = new Position(0, 0);

            //above
            pos.defineValues(position.row - 1, position.column);
            while (brd.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
                if (brd.piece(pos) != null && brd.piece(pos).color != color) {
                    break;
                }
                pos.row = pos.row - 1;
            }
            //right
            pos.defineValues(position.row, position.column + 1);
            while (brd.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
                if (brd.piece(pos) != null && brd.piece(pos).color != color)
                {
                    break;
                }
                pos.column = pos.column + 1;
            }
            //below
            pos.defineValues(position.row + 1, position.column);
            while (brd.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
                if (brd.piece(pos) != null && brd.piece(pos).color != color)
                {
                    break;
                }
                pos.row = pos.row + 1;
            }
            //left
            pos.defineValues(position.row, position.column - 1);
            while (brd.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
                if (brd.piece(pos) != null && brd.piece(pos).color != color)
                {
                    break;
                }
                pos.column = pos.column - 1;
            }
            return mat;
        }
        private bool canMove(Position pos)
        {
            Pieces p = brd.piece(pos);
            return p == null || p.color != this.color;
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
