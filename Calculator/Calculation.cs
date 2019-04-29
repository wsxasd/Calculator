using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculation
    {
        public string GetResult(double firstNumber, double secondNumber, string operation)
        {
            switch (operation)
            {
                case "+":
                    return $"Result: {GetSum(firstNumber, secondNumber)}";
                case "-":
                    return $"Result: {GetSubtraction(firstNumber, secondNumber)}";
                case "*":
                    return $"Result: {GetMultiplication(firstNumber, secondNumber)}";
                case "/":
                    return $"Result: {GetDivision(firstNumber, secondNumber)}";
                default:
                    return "None";
            }
        }

        private double GetMultiplication(double a, double b)
        {
            return a * b;
        }

        private double GetDivision(double a, double b)
        {
            return a / b;
        }

        private double GetSum(double a, double b)
        {
            return a + b;
        }

        private double GetSubtraction(double a, double b)
        {
            return a - b;
        }
    }
}
