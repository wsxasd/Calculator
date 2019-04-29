using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ConsoleReader
    {
        public double GetFirstNumber()
        {
            Console.Write("Enter first number: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        public double GetSecondNumber()
        {
            Console.Write("Enter second number: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        public string GetOperator()
        {
            Console.Write("Enter operator: ");
            return Console.ReadLine();
        }
    }
}
