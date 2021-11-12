using System;

namespace CarFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Car Factory :)");
/*            var ans = Console.ReadLine();
            for (int i = 0; i < int.Parse(ans); i++)
            {
                Car car = new Car();
                car.CurrentSpeedInKPH = 100;
                Console.WriteLine(car.CurrentSpeedInKPH);
            }*/
            bool continueProgram = true;

            while (continueProgram)
            {
                Console.WriteLine("How many cars would you like to make?\nEnter x to exit...");
                var amountOfCars = Console.ReadLine();
                if (int.TryParse(amountOfCars, out int amount))
                {
                    for (int i = 0; i < amount; i++)
                    {
                        Car car = new Car();
                    }
                    Console.WriteLine($"You've created {Car.TotalNumberOfCars} car(s).");
                }
                else if (amountOfCars.ToUpperInvariant() == "X")
                {
                    continueProgram = false;
                    Console.WriteLine($"You created {Car.TotalNumberOfCars} car(s)");
                }
                else
                {
                    Console.WriteLine($"Please enter a valid number, {amountOfCars} is not a number");
                }
            }
        }
    }
}
