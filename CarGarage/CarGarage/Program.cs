using System;

namespace CarGarage
{
    class Program
    {
        public static Garage myGarage = new Garage();
        public static int currentCarPosition;
        
       
        static void Main(string[] args)
        {

            MainMenu();

            
            void MainMenu()
            {
                Console.Clear();
                

                Console.WriteLine("=====Main Menu=====");
                Console.WriteLine("1. Add a car to the garage");
                Console.WriteLine("2. Remove a car from the garage");
                Console.WriteLine("3. List all cars.");
                Console.WriteLine("4. Interact with the car.");
                

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        myGarage.AddCar();
                        MainMenu();
                        break;
                    case "2":
                        myGarage.RemoveCar();
                        MainMenu();
                        break;
                    case "3":
                        myGarage.AllStatus();
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadKey();
                        MainMenu();
                        break;
                    case "4":
                        CarActions();
                        break;
                    default:
                        Console.WriteLine("Please choose an appropriate number.");
                        MainMenu();
                        break;
                }
                
            }

            void CarActions()
            {
                Console.Clear();
                Console.WriteLine("What should we do with the " + myGarage.cars[currentCarPosition].Make + " " + myGarage.cars[currentCarPosition].Model);
                Console.WriteLine("1. Turn on/off engine");
                Console.WriteLine("2. Accelerate");
                Console.WriteLine("3. Brake");
                Console.WriteLine("4. Get gas)");
                Console.WriteLine("5. Return to Main Menu");
                string input = Console.ReadLine();
                Car myCurrentCar = myGarage.cars[currentCarPosition];
                switch (input)
                {
                    case "1":
                        myCurrentCar.ToggleEngine();
                        if (myCurrentCar.Started == true)
                        {
                            Console.WriteLine("You turned on the car!");
                        }
                        else 
                        {
                            Console.WriteLine("You turned off the car!");
                        }
                        Console.ReadKey();
                        MainMenu();
                        break;
                    case "2":
                        myCurrentCar.Accelerate();
                        Console.WriteLine("You stepped on the gas! Speed is went up!");
                        Console.ReadKey();
                        MainMenu();
                        break;
                    case "3":
                        myCurrentCar.Brake();
                        Console.WriteLine("BREAK CHECK!!!! Your speed went down!");
                        Console.ReadKey();
                        MainMenu();
                        break;
                    case "4":
                        myCurrentCar.AddFuel();
                        Console.WriteLine("You filled up the tank. Wow! Someone's rich!");
                        Console.ReadKey();
                        MainMenu();
                        break;
                    case "5":
                        MainMenu();
                        break;
                    default:
                        Console.WriteLine("Please choose the number for the action.");
                        CarActions();
                        break;
                }
            }

            void ListAllCars()
            {
                
                int currentCarPosition = 0;
                foreach (Car car in myGarage.cars)
                {
                    Console.WriteLine((currentCarPosition += 1) + ". Make: " + car.Make + " Model: " + car.Model);
                }
            }

            void SwitchCurrent()
            {
                Console.Clear();
                Console.WriteLine("Please Choose Car!");
                Console.WriteLine();

                currentCarPosition = 0;
                foreach (Car current in myGarage.cars)
                {
                    Console.WriteLine((currentCarPosition += 1) + ". " + current.Make + " " + current.Model);

                }

                Console.WriteLine();
                Console.WriteLine("Choose the number of the car you want to choose!");
                string carPosition = Console.ReadLine();
                currentCarPosition = Int32.Parse(carPosition);
                currentCarPosition--;

                Console.Clear();
                Console.WriteLine("You are now using " + myGarage.cars[currentCarPosition].Make + " " + myGarage.cars[currentCarPosition].Model);
                Console.ReadKey();
                MainMenu();
            }





        }

        
    }
}
