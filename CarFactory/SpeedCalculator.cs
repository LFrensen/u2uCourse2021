using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    static class SpeedCalculator
    {
        private static double MphToKmpConversionRate = 1.603944;
        public static double FromMilesToKilometers(double mph)
        {
            return mph * MphToKmpConversionRate;
        }

        public static double FromKilometersToMiles(double kph)
        {
            return kph / MphToKmpConversionRate;
        }
    }
}
