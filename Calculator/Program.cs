using System;
using System.Linq;

namespace Calculator
{
    class Program
    {
        static double GetMultiplication(double a, double b) => a * b;

        static double GetDivision(double a, double b) => a / b;

        static double GetSum(double a, double b) => a + b;

        static double GetSubtraction(double a, double b) => a - b;

        static double GetFirstNumber()
        {
            Console.Write("Enter first number: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        static double GetSecondNumber()
        {
            Console.Write("Enter second number: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        static string GetOperator()
        {
            Console.Write("Enter operator: ");
            return Console.ReadLine();
        }

        public static string GetResult(double firstNumber, double secondNumber)
        {
            switch (GetOperator())
            {
                case "+":
                    return "Result: " + GetSum(firstNumber, secondNumber);
                case "-":
                    return  "Result: " + GetSubtraction(firstNumber, secondNumber);
                case "*":
                    return  "Result: " + GetMultiplication(firstNumber, secondNumber);
                case "/":
                    return  "Result: " + GetDivision(firstNumber, secondNumber);
                default:
                    return "None";
            }
        }

        static void Main(string[] args)
        {
            double firstNumber = GetFirstNumber();
            double secondNumber = GetSecondNumber();
            Console.WriteLine(GetResult(firstNumber, secondNumber));
            Console.ReadKey();
        }
    }
}
