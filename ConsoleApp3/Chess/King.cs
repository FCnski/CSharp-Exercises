using System;
using Board;
using Board.enums;

namespace Chess
{
    class King : Pieces
    {
        public King(GameBoard brd, Color color) : base(brd, color)
        {
            
        }

        public override bool[,] possibleMovements()
        {
            bool[,] mat = new bool[brd.rows, brd.columns] ;

            Position pos = new Position(0, 0);

            //above
            pos.defineValues(position.row - 1, position.column);
            if(brd.validPosition(pos) && canMove(pos)) 
            {
                mat[pos.row, pos.column] = true;
            }
            //ne
            pos.defineValues(position.row - 1, position.column + 1);
            if (brd.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }
            //right
            pos.defineValues(position.row, position.column + 1);
            if (brd.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }
            //se
            pos.defineValues(position.row + 1, position.column + 1);
            if (brd.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }
            //below
            pos.defineValues(position.row + 1, position.column);
            if (brd.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }
            //sw
            pos.defineValues(position.row + 1, position.column - 1);
            if (brd.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }
            //left
            pos.defineValues(position.row, position.column - 1);
            if (brd.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }
            //nw
            pos.defineValues(position.row - 1, position.column - 1);
            if (brd.validPosition(pos) && canMove(pos))
            {
                mat[pos.row, pos.column] = true;
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
            return "K";
        }
        

    }
}
