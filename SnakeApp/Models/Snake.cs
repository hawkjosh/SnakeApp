namespace SnakeApp.Models
{
    public class Snake  // This handles the snake's attributes like length, position, movement, etc.
    {
        // TODO: Add properties and methods to manage the snake
        public List<(int, int)> Position { get; set; } // List of coordinates (x, y)
        public Direction CurrentDirection { get; set; } // Enum for the snake's current facing direction
        public int Length { get; set; } = 1; // Length of the snake, set initially to 1
        public bool IsActive { get; set; } = false; // Is the snake active or inactive, set initially to false

        public Snake()
        {
            Position = new List<(int, int)>() { (50, 50) };
            CurrentDirection = Direction.Up; // Set the initial direction of the snake to up
            Length = 1; // Set the initial length of the snake to 1
        }

        public void Move()
        {
            Position = new List<(int, int)>(); // Clear the list

            switch (CurrentDirection)
            {
                case Direction.Up:
                    Position.Add((Position[0].Item1, Position[0].Item2 - 1));
                    break;
                case Direction.Down:
                    Position.Add((Position[0].Item1, Position[0].Item2 + 1));
                    break;
                case Direction.Left:
                    Position.Add((Position[0].Item1 - 1, Position[0].Item2));
                    break;
                case Direction.Right:
                    Position.Add((Position[0].Item1 + 1, Position[0].Item2));
                    break;
            }

        }

        public void Grow()
        {
            Position.Add((Position[Position.Count - 1].Item1, Position[Position.Count - 1].Item2));
        }

        // TODO: Add more methods to manage the snake
    }

    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
}
