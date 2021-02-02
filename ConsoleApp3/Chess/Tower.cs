using System;
using Board;
using Board.enums;

namespace Chess
{
    class Tower : Pieces
    {
        public Tower(GameBoard brd, Color color) : base(brd, color)
        {

        }
        public override string ToString()
        {
            return "T";
        }
    }
}
