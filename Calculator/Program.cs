using System;

namespace Calculator
{
    class Program
    {
        static double GetMultiplication(double a, double b) => a * b;

        static double GetDivision(double a, double b) => a / b;

        static double GetSum(double a, double b) => a + b;

        static double GetSubtraction(double a, double b) => a - b;

        static double GetFisrtNumber()
        {
            Console.Write("Enter first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            return firstNumber;
        }

        static double GetSecondtNumber()
        {
            Console.Write("Enter second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            return secondNumber;
        }

        static string GetOperator()
        {
            Console.Write("Enter operator: ");
            string actionOperator = Console.ReadLine();
            return actionOperator;
        }

        public static void GetResult(double firstNumber, double secondNumber)
        {
            switch (GetOperator())
            {
                case "+":
                    Console.WriteLine("Result: " + GetSum(firstNumber, secondNumber));
                    break;
                case "-":
                    Console.WriteLine("Result: " + GetSubtraction(firstNumber, secondNumber));
                    break;
                case "*":
                    Console.WriteLine("Result: " + GetMultiplication(firstNumber, secondNumber));
                    break;
                case "/":
                    Console.WriteLine("Result: " + GetDivision(firstNumber, secondNumber));
                    break;
            }
        }

        static void Main(string[] args)
        {
            double firstNumber = GetFisrtNumber();
            double secondNumber = GetSecondtNumber();
            GetResult(firstNumber, secondNumber);
            Console.ReadKey();
        }
    }
}
