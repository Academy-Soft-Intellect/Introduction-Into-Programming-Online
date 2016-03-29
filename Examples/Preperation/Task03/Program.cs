using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;
            for (int i = 0; i < 10; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    if (currentNumber > maxNumber)
                    {
                        maxNumber = currentNumber;
                    }
                }
                else
                {
                    if (currentNumber < minNumber)
                    {
                        minNumber = currentNumber;
                    }
                }
            }

            Console.WriteLine("Max number is:" + maxNumber);
            Console.WriteLine("Min number is:" + minNumber);
        }
    }
}
