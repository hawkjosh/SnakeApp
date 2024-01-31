namespace SnakeApp.Models
{
    public class Snake  // This handles the snake's attributes like length, position, movement, etc.
    {
        public Board Board = new(); // Create a new board instance
        public List<(int, int)> Position = []; // List of coordinates (x, y)
        public (int, int) SnakeHead => Position[0]; // Head of the snake (first element in the Position list)
        public Direction Direction { get; set; } // Enum for the snake's current facing direction
        public int Length { get; set; } // Length of the snake (will also be the count of the Position list)
        public bool IsActive { get; set; } // Is the snake active or inactive

        public Snake() // Initialize the snake with a list of coordinates, a direction, and a length
        {
            Board.BoardWidth = 75;
            Board.BoardHeight = 50;

            int StartX = Board.BoardWidth / 2;
            int StartY = Board.BoardHeight / 2;

            Position.Add((StartX, StartY)); // Add starting position of snake to Position list
            Direction = Direction.Up; // Set initial direction of snake to up
            Length = 1; // Set initial length of snake to 1
            IsActive = false; // Set initial state of snake to inactive
        }

        public void Move(Direction Direction)
        {
            IsActive = true;
            var (x, y) = Position[0];
            switch (Direction)
            {
                case Direction.Up:
                    y--;
                    break;
                case Direction.Down:
                    y++;
                    break;
                case Direction.Left:
                    x--;
                    break;
                case Direction.Right:
                    x++;
                    break;
            }
            Position.Insert(0, (x, y));
            Position.RemoveAt(Position.Count - 1);
        }

        public void Grow()
        {
            var (x, y) = Position[0];
            switch (Direction)
            {
                case Direction.Up:
                    y--;
                    break;
                case Direction.Down:
                    y++;
                    break;
                case Direction.Left:
                    x--;
                    break;
                case Direction.Right:
                    x++;
                    break;
            }
            Position.Add((x, y));
        }

        // TODO: Add other methods to manage the snake
    }

    public enum Direction
    {
        Up = 0,
        Down = 1,
        Left = 2,
        Right = 3
    }
}
