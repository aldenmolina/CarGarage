using System;

namespace CarGarage
{
    class Program
    {
        public static Garage myGarage = new Garage();
        public static Car car = new Car("BMW", "325i");
        public static Car car2 = new Car("Ford", "Focus");
        public static Car car3 = new Car("Bucatti", "Veyron");
        public static int currentCarPosition;
        
       
        static void Main(string[] args)
        {

            AddFirstThreeCars();
            MainMenu();
            SwitchCurrent();

            void AddFirstThreeCars()
            {
                myGarage.AddCar(car);
                myGarage.AddCar(car2);
                myGarage.AddCar(car3);
            }
            void MainMenu()
            {
                Console.Clear();
                Console.WriteLine("The current car is " + myGarage.cars[currentCarPosition].Make + " " + myGarage.cars[currentCarPosition].Model);
                Console.WriteLine("=====Main Menu=====");
                Console.WriteLine("1. Interact with current car.");
                Console.WriteLine("2. Switch current car.");
                Console.WriteLine("3. See all car status.");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        CarActions();
                        break;
                    case "2":
                        SwitchCurrent();
                        break;
                    case "3":
                        myGarage.AllStatus();
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
