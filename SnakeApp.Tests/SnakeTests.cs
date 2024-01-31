using SnakeApp.Models;

namespace SnakeApp.Tests
{
    [TestClass]
    public class SnakeTests
    {
        [TestMethod]
        public void CheckInitialSnake()
        {
            // Arrange
            var snake = new Snake();

            // Act - No action needed for this test

            // Assert
            Assert.AreEqual(false, snake.IsActive, "The initial state of the snake should be inactive");
            Assert.AreEqual(Direction.Up, snake.Direction, "The initial snake direciton should be up");
            Assert.AreEqual(50, snake.Position.First().Item1, "The initial X position should be half of the conosle width");
            Assert.AreEqual(50, snake.Position.First().Item2, "The initial Y position should be half of the console height");
            Assert.AreEqual(1, snake.Length, "The initial length of the snake should be 1");
        }

        [TestMethod]
        public void CheckSnakeAfterStartUp()
        {
            // Arrange
            var snake = new Snake();
            var initialIsActive = snake.IsActive;
            var initialDirection = snake.Direction;
            var initialXPosition = snake.Position.First().Item1;
            var initialYPosition = snake.Position.First().Item2;
            var initialLength = snake.Length;

            // Act
            snake.Move(Direction.Up);

            // Assert
            Assert.AreNotEqual(initialIsActive, snake.IsActive, "Any movement from start should change the initial snake state");
            Assert.AreEqual(initialDirection, snake.Direction, "Moving up should not change the initial snake direction");
            Assert.AreEqual(initialXPosition, snake.Position.First().Item1, "Moving up should not change X position");
            Assert.AreEqual(initialYPosition - 1, snake.Position.First().Item2, "Moving up should decrease Y position");
            Assert.AreEqual(initialLength, snake.Length, "Moving up without hitting food should not change the initial length of snake");
        }

        [TestMethod]
        public void CheckSnakeAfterStartRight()
        {
            // Arrange
            var snake = new Snake();
            var initialIsActive = snake.IsActive;
            var initialDirection = snake.Direction;
            var initialXPosition = snake.Position.First().Item1;
            var initialYPosition = snake.Position.First().Item2;
            var initialLength = snake.Length;

            // Act
            snake.Direction = Direction.Right;
            snake.Move(Direction.Right);

            // Assert
            Assert.AreNotEqual(initialIsActive, snake.IsActive, "Any movement from start should change the initial snake state");
            Assert.AreNotEqual(initialDirection, snake.Direction, "Moving right should change the initial snake direction");
            Assert.AreEqual(initialXPosition + 1, snake.Position.First().Item1, "Moving right should increase X position");
            Assert.AreEqual(initialYPosition, snake.Position.First().Item2, "Moving right should not change Y position");
            Assert.AreEqual(initialLength, snake.Length, "Moving right without hitting food should not change the initial length of snake");
        }

        [TestMethod]
        public void CheckSnakeAfterStartDown()
        {
            // Arrange
            var snake = new Snake();
            var initialIsActive = snake.IsActive;
            var initialDirection = snake.Direction;
            var initialXPosition = snake.Position.First().Item1;
            var initialYPosition = snake.Position.First().Item2;
            var initialLength = snake.Length;

            // Act
            snake.Direction = Direction.Down;
            snake.Move(Direction.Down);

            // Assert
            Assert.AreNotEqual(initialIsActive, snake.IsActive, "Any movement from start should change the initial snake state");
            Assert.AreNotEqual(initialDirection, snake.Direction, "Moving down should change the initial snake direction");
            Assert.AreEqual(initialXPosition, snake.Position.First().Item1, "Moving down should not change X position");
            Assert.AreEqual(initialYPosition + 1, snake.Position.First().Item2, "Moving down should increase Y position");
            Assert.AreEqual(initialLength, snake.Length, "Moving down without hitting food should not change the initial length of snake");
        }

        [TestMethod]
        public void CheckSnakeAfterStartLeft()
        {
            // Arrange
            var snake = new Snake();
            var initialIsActive = snake.IsActive;
            var initialDirection = snake.Direction;
            var initialXPosition = snake.Position.First().Item1;
            var initialYPosition = snake.Position.First().Item2;
            var initialLength = snake.Length;

            // Act
            snake.Direction = Direction.Left;
            snake.Move(Direction.Left);

            // Assert
            Assert.AreNotEqual(initialIsActive, snake.IsActive, "Any movement from start should change the initial snake state");
            Assert.AreNotEqual(initialDirection, snake.Direction, "Moving left should change the initial snake direction");
            Assert.AreEqual(initialXPosition - 1, snake.Position.First().Item1, "Moving left should decrease X position");
            Assert.AreEqual(initialYPosition, snake.Position.First().Item2, "Moving left should not change Y position");
            Assert.AreEqual(initialLength, snake.Length, "Moving left without hitting food should not change the initial length of snake");
        }

        // TODO: Add other tests for Snake class

    }
}