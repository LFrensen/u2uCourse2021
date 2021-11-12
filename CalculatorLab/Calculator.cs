using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLab
{
    public class Calculator
    {
        private double tempResult;
        public delegate double Operation(double first, double second);

        public void Init(double input)
        {
            tempResult = input;
        }
        public double Calculate(Operation operation, double input)
        {
            return tempResult = operation.Invoke(tempResult, input);
        }
        public double GetResult()
        {
            return tempResult;
        }

    }
}
