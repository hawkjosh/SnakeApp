﻿namespace SnakeApp.Models
{
    public class Game  // This manages the state of the game
    {
        public Snake Snake { get; private set; }
        public Food Food { get; private set; }
        public Board Board { get; private set; }

        public Game()
        {
            Snake = new Snake();
            Food = new Food();
            Board = new Board();
        }

        // TODO: Add methods for game logic (starting, updating state, checking for game over, etc.)
    }
}
