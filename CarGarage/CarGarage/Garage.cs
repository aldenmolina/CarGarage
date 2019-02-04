using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Garage
    {
        public List<Car> cars { get; private set; }
        public Car car;

        public Garage()
        {
            cars = new List<Car>();
            
        }
        public void AddCar(Car car)
        {
            cars.Add(car);
        }
        public void RemoveCar(Car car)
        {
            cars.Remove(car);
        }
        public void FuelAllCars()
        {
            foreach (Car car in cars)
            {
                car.AddFuel();
            }
        }

        public void AllStatus()
        {
            Console.Clear();
            int carPosition = 0;
            foreach (Car car in garage.cars)
            {
                Console.WriteLine((carPosition += 1) + ". " + car.Make + " " + car.Model);
                Console.WriteLine("Started: " + car.Started);
                Console.WriteLine("Speed: " + car.Speed);
                Console.WriteLine("Fuel: " + car.Fuel);
            }
            
        }

    }
}
