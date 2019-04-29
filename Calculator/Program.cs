using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleReader consoleReader = new ConsoleReader();
            Calculation calculation = new Calculation();

            Console.WriteLine(calculation.GetResult(consoleReader.GetFirstNumber(), 
                consoleReader.GetSecondNumber(), 
                consoleReader.GetOperator()));
            Console.ReadKey();
        }
    }
}
