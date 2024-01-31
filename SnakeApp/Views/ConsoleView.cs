using SnakeApp.Models;

namespace SnakeApp.Views
{
    public class ConsoleView  // This handles all the console output, like drawing the game board, snake, and food
    {
        public ConsoleView() // Constructor: initialize console window settings
        {
            Console.CursorVisible = false; // Hide the cursor
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight); // Set the window size to the largest possible
        }

        public void Render(Game game) // Called by GameController to draw game state on console
        {
            Clear(); // Clear the console
            DrawBoard(game.Board); // Draw the game board
            DrawSnake(game.Snake); // Draw the snake
            DrawFood(game.Food); // Draw the food
        }

        private void Clear() // Method to clear the console
        {
            Console.Clear();
        }

        private void DrawBoard(Board Board) // Method to draw the game board with a border
        {
            //for (int y = 0; y < Board.BoardHeight; y++)
            //{
            //    for (int x = 0; x < Board.BoardWidth; x++)
            //    {
            //        if (x == 0 || y == 0 || x == Board.BoardWidth - 1 || y == Board.BoardHeight - 1)
            //        {
            //            Console.SetCursorPosition(x, y);
            //            Console.Write("#"); // Character representing the border
            //        }
            //    }
            //}
            // Draw the top border
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < Board.BoardWidth / 2; i++)
            {
                Console.Write("#");
            }

            // Draw the side borders
            Console.SetCursorPosition(0, 1);
            for (int i = 0; i < Board.BoardHeight - 1; i++)
            {
                Console.Write("#" + new string(' ', (Board.BoardWidth / 2) - 1) + "#");
                //Console.SetCursorPosition(Board.BoardWidth - 1, i + 1);
                //Console.Write("#");
            }

            // Draw the bottom border
            Console.SetCursorPosition(0, Board.BoardHeight - 1);
            for (int i = 0; i < Board.BoardWidth / 2; i++)
            {
                Console.Write("#");
            }
        }

        private void DrawSnake(Snake Snake) // Method to draw the Snake
        {
            foreach (var (x, y) in Snake.Position)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("*"); // Character representing the snake
            }
        }

        private void DrawFood(Food Food) // Method to draw the food
        {
            //Console.SetCursorPosition(Food.Position.X, Food.Position.Y);
            Console.SetCursorPosition(25, 25);
            Console.Write("O"); // Character representing the food
        }
    }
}
