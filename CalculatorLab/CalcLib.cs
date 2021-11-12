using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLab
{
    public static class CalcLib
    {
        public static double Add(double first, double second)
        {
            return first + second;
        }
        public static double Divide(double first, double second)
        {
            return first / second;
        }
        public static double Multiply(double first, double second)
        {
            return second * first;
        }
        public static double Subtract(double first, double second)
        {
            return first - second;
        }
    }
}
