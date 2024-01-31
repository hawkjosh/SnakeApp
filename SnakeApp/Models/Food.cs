namespace SnakeApp.Models
{
    public class Food  // This manages the position and type of food items on the board
    {
        public Board Board = new(); // Create a new board instance
        public List<(int, int)> Position = []; // List of coordinates (x, y)
        public (int, int) FoodLocation => Position[0]; // Position of the food (first element in the Position list)

        public Food() // Initialize food with randomly spawned food item
        {
            Board.BoardWidth = 75;
            Board.BoardHeight = 50;

            Spawn(); // Spawn random food at start
        }

        public void Spawn()
        {
            Random rand = new Random();
            int minX = 1;
            int maxX = Board.BoardWidth - 1;
            int minY = 1;
            int maxY = Board.BoardHeight - 1;
            int randX = rand.Next(minX, maxX);
            int randY = rand.Next(minY, maxY);
            Position.Add((randX, randY));

            // TODO: Create logic to avoid spawning food on the snake
        }

        // TODO: Add other methods to manage the food
    }
}
