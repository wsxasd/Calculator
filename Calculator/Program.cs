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
            double first_number = Convert.ToDouble(Console.ReadLine());
            if (IsDigit(first_number))
            return first_number;
        }

        static double GetSecondtNumber()
        {
            Console.Write("Enter second number: ");
            double second_number = Convert.ToDouble(Console.ReadLine());
            return second_number;
        }

        static string GetOperator()
        {
            Console.Write("Enter operator: ");
            string action_operator = Console.ReadLine();
            return action_operator;
        }

        public static void GetResult(double first_number, double second_number)
        {
            switch (GetOperator())
            {
                case "+":
                    Console.WriteLine("Result: " + GetSum(first_number, second_number));
                    break;
                case "-":
                    Console.WriteLine("Result: " + GetSubtraction(first_number, second_number));
                    break;
                case "*":
                    Console.WriteLine("Result: " + GetMultiplication(first_number, second_number));
                    break;
                case "/":
                    Console.WriteLine("Result: " + GetDivision(first_number, second_number));
                    break;
            }
        }

        static void Main(string[] args)
        {
            double first_number = GetFisrtNumber();
            double second_number = GetSecondtNumber();
            GetResult(first_number, second_number);
            Console.ReadKey();
        }
    }
}
