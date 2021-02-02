using Board.enums;

namespace Board
{
    abstract class Pieces
    {
        public Position position { get; set; }
        public Color color { get; protected set; }
        public int AmountOfMovements { get; protected set; }
        public GameBoard brd { get; protected set; }

        public Pieces(GameBoard brd, Color color)
        {
            this.position = null;
            this.brd = brd;
            this.color = color;
            this.AmountOfMovements = 0;

        }

        public void increaseAmountOfMovements()
        {
            AmountOfMovements++;
        }

        public abstract bool[,] possibleMovements();
    }
}
