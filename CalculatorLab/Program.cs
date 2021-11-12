using CalculatorLab;

Calculator calculator = new Calculator();
calculator.Init(1);
calculator.Calculate(CalcLib.Multiply, 19);
Console.WriteLine(calculator.GetResult());