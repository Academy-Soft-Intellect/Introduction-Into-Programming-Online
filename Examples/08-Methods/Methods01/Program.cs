using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            PrintNumbersSum(firstNumber, secondNumber);
        }

        private static void PrintNumbersSum(int firstNumber, int secondNumber)
        {
            Console.Write("{0} + {1} = ", firstNumber, secondNumber);
            Console.WriteLine(firstNumber + secondNumber);
        }
    }
}
