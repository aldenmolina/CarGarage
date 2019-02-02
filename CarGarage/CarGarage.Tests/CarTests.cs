using System;
using Xunit;

namespace CarGarage.Tests
{
    public class CarTests
    {
        [Fact]
        public void shouldAccelerate()
        {
            // Tests Accelerate() method in Car increases Speed
            // Arrange
            Car testCar = new Car();

            // Act
            testCar.Accelerate();

            // Assert
            Assert.Equal(60, testCar.Speed);
        }

        [Fact]
        public void shouldConsumeFuel()
        {
            // Tests Accelerate() method reduces Fuel amount
            // Arrange
            Car testCar = new Car();

            // Act
            testCar.Accelerate();

            // Assert
            Assert.Equal(90, testCar.Fuel);
        }

        [Fact]
        public void shouldRefuel()
        {
            // Tests AddFuel() method increases Fuel amount
            // Arrange
            Car testCar = new Car(50);

            // Act
            testCar.AddFuel();

            // Assert
            Assert.Equal(100, testCar.Fuel);
        }

        [Fact]
        public void shouldSlowDown()
        {
            // Tests Brake() method in Car reduces Speed amount
            // Arrange
            Car testCar = new Car();
            testCar.Speed = 100;    

            // Act
            testCar.Brake();

            // Assert
            Assert.Equal(0, testCar.Speed);
        }

        [Fact]
        public void shouldStart()
        {
            // Tests ToggleEngine() method starts car when its off
            // Arrange
            Car testCar = new Car();

            // Act
            testCar.ToggleEngine();

            // Assert
            Assert.True(testCar.Started);
        }

        [Fact]
        public void shouldTurnOff()
        {
            // Tests ToggleEngine() method turns car off when its on
            // Arrange
            Car testCar = new Car();
            
            // Act
            testCar.ToggleEngine();
            testCar.ToggleEngine();

            // Assert
            Assert.False(testCar.Started);
        }
    }
}
