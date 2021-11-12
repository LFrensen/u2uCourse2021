using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CarFactory
{
    public class Car
    {
        public static int TotalNumberOfCars { get; set; }
        public bool SteeringWheelLeft { get; set; }
        public bool ShowSpeedInMph { get; set; }
        private double currentSpeedInKPH;

        public double CurrentSpeedInKPH
        {
            get 
            { 
                if(ShowSpeedInMph)
                {
                    currentSpeedInKPH = SpeedCalculator.FromKilometersToMiles(currentSpeedInKPH);
                }
                return currentSpeedInKPH; 
            }
            set { currentSpeedInKPH = value; }
        }

        public static double KmpToMph = 0.621371192;

        public Car()
        {
            Thread.Sleep(1000); //5s
            Console.WriteLine("You have instantiated an Car object");
            TotalNumberOfCars++;
            if (TotalNumberOfCars % 4 == 0)
            {
                SteeringWheelLeft = true;
                ShowSpeedInMph = true;
            }
        }
    }
}
