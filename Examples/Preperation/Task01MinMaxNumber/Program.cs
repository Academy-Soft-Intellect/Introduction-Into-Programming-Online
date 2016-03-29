using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01MinMaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;

            for (int i = 0; i < 5; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
                if (number < minNumber)
                {
                    minNumber = number;
                }
            }

            Console.WriteLine("Max number is:" + maxNumber);
            Console.WriteLine("Min number is:" + minNumber);
        }
    }
}
