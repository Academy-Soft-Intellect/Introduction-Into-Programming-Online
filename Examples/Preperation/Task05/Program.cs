using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;
            int maxHeight = 0;
            int maxWidth = 0;
            int minNumber = int.MaxValue;
            int minHeight = 0;
            int minWidth = 0;

            int[,] matrix = new int[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());

                    if (matrix[i, j] > maxNumber)
                    {
                        maxNumber = matrix[i, j];
                        maxHeight = i;
                        maxWidth = j;
                    }
                    if (matrix[i, j] < minNumber)
                    {
                        minNumber = matrix[i, j];
                        minHeight = i;
                        minWidth = j;
                    }
                }
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(" " + matrix[i,j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Max number is {0} and is located on [{1}:{2}]", maxNumber, maxHeight, maxWidth);
            Console.WriteLine("Min number is {0} and is located on [{1}:{2}]", minNumber, minHeight, minWidth);
        }
    }
}
