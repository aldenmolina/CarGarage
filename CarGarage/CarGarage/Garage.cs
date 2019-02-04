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
       

        public void AddCar()
        {
            Console.Clear();
            Console.WriteLine("What Make is the car?");
            string make = Console.ReadLine();
            Console.WriteLine("What Model is the car?");
            string model = Console.ReadLine();
            Console.Clear();
            Car car = new Car(make, model);
            cars.Add(car);
            Console.WriteLine("CONGRATULIONS! YOU GOT A NEW CAR!");
            Console.ReadKey();
            
        }



        public void RemoveCar()
        {
            Console.Clear();
            Console.WriteLine("Choose which car to remove from the garage");
            int currentCarPosition = 0;
            foreach (Car car in cars)
            {
                Console.WriteLine((currentCarPosition += 1) + ". Make: " + car.Make + " Model: " + car.Model);
            }

            currentCarPosition = Convert.ToInt32(Console.ReadLine());
            currentCarPosition--;
            cars.Remove(cars[currentCarPosition]);
            Console.WriteLine("YOU HAVE REMOVED " + cars[currentCarPosition].Make + " " + cars[currentCarPosition].Model);
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
            foreach (Car car in cars)
            {
                Console.WriteLine((carPosition += 1) + ". " + car.Make + " " + car.Model);
                Console.WriteLine("Started: " + car.Started);
                Console.WriteLine("Speed: " + car.Speed);
                Console.WriteLine("Fuel: " + car.Fuel);
            }
            
        }

    }
}
