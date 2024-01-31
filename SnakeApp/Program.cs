using SnakeApp.Controllers;

namespace SnakeApp
{
    public class Program
    {
        static void Main()
        {
            var NewGame = new GameController();
            NewGame.Start();

            //Console.Write("Press any key to exit . . . ");
            //Console.Read();
        }
    }
}
