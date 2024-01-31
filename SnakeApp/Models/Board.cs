namespace SnakeApp.Models
{
    public class Board  // This deals with the dimensions and boundaries of the game area
    {
        public static int BoardWidth
        {
            get
            {
                return Console.WindowWidth;
            }
            set
            {
                if (value > 0 && value <= Console.LargestWindowWidth)
                {
                    Console.WindowWidth = value;
                }
                else
                {
                    // Handle case where provided value is out of bounds
                    Console.WriteLine("Invalid width. Setting to default max value.");
                    Console.WindowWidth = Console.LargestWindowWidth;
                }
            }
        }

        public static int BoardHeight
        {
            get
            {
                return Console.WindowHeight;
            }
            set
            {
                if (value > 0 && value <= Console.LargestWindowHeight)
                {
                    Console.WindowHeight = value;
                }
                else
                {
                    // Handle case where provided value is out of bounds
                    Console.WriteLine("Invalid height. Setting to default min value.");
                    Console.WindowHeight = Console.LargestWindowHeight;
                }
            }
        }
    }
}
