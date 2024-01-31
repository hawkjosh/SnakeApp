using SnakeApp.Views;

namespace SnakeApp.Controllers
{
    public class GameController  // This manages and controls the game flow, handling user inputs, and updating the model
    {
        ConsoleView ConsoleView = new ConsoleView();
        Models.Game Game = new Models.Game();
        public GameController() { }
        public void Start()
        {
            // TODO: Implement additional game loop functions (process input, update game state, etc.)

            ConsoleView.Render(Game);
        }
    }
}
