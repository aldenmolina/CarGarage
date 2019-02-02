using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Car
    {
        public int Speed { get; set; }
        public int Fuel { get; set; }
        public bool Started { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public Car()
        {
            Speed = 0;
            Fuel = 100;
            Started = false;
        }

        public Car(string make, string model)
        {
            Make = make;
            Model = model;
            Speed = 0;
            Fuel = 100;
            Started = false;
        }

        public Car(int startingFuel)
        {
            Speed = 0;
            Fuel = startingFuel;
            Started = false;
        }

        public void Accelerate()
        {
            Speed += 60;
            Fuel -= 10;
        }

        public void AddFuel()
        {
            Fuel = 100;
        }

        public void Brake()
        {
            Speed = 0;
        }

        public void ToggleEngine()
        {
            if (Started)
            {
                Started = false;
            }
            else
            {
                Started = true;
            }
        }
    }
}
