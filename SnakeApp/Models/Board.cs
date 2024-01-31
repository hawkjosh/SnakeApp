namespace SnakeApp.Models
{
    public class Board  // This deals with the dimensions and boundaries of the game area
    {
        // TODO: Add properties and methods to manage the board
        public int BoardWidth { get; set; };
        public int BoardHeight { get; set; };

        public Board()
        {
            BoardWidth = Console.WindowWidth;
            BoardHeight = Console.WindowHeight;
        }
    }
}
