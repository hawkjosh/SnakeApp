using SnakeApp.Models;

namespace SnakeApp.Tests
{
    [TestClass]
    public class SnakeTests
    {
        [TestMethod]
        public void Move_Up_Increases_Y_Position()
        {
            // Arrange
            var snake = new Snake();
            var initialYPosition = snake.Position.First().Item2;

            // Act
            snake.CurrentDirection = Direction.Up;
            snake.Move();

            // Assert
            Assert.AreEqual(initialYPosition + 1, snake.Position.First().Item2, "Moving up should increase Y position");
        }

        // TODO: Add more tests for the Snake class
    }
}