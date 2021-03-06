﻿using System;
using Xunit;

namespace CarGarage.Tests
{
    public class GarageTests
    {
        [Fact]
        public void shouldAddCarToGarage()
        {
            // Tests AddCar() method
            // Arrange      
            Garage cars = new Garage();
            Car testCar = new Car();

            // Act 
            cars.AddCar();

            // Assert
            Assert.NotEmpty(cars.cars);
        }

        [Fact]
        public void shouldRemoveCarFromGarage()
        {
            // Tests RemoveCar() method
            // Arrange
            Garage myGarage = new Garage();
            Car testCar = new Car();

            // Act
            myGarage.AddCar();
            myGarage.RemoveCar();

            // Assert
            Assert.Empty(myGarage.cars);
        }

        [Fact]
        public void shouldFuelAllCars()
        {
            // Tests FuelAllCars() method
            // Arrange
            Garage myGarage = new Garage();
            Car testCar = new Car();
            Car testCar2 = new Car();
            testCar.Fuel = 50;
            testCar2.Fuel = 50;
            myGarage.AddCar();
            myGarage.AddCar();

            // Act
            myGarage.FuelAllCars();

            // Assert
            Assert.Equal(100, testCar.Fuel);
            Assert.Equal(100, testCar2.Fuel);
        }


    }
}
