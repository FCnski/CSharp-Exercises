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
            public override string ToString()
        {
            return "R";
        } 
    }
}
