using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int side = 0;
            do
            {
                Console.WriteLine("Please enter matrix side, between 2 and 9:");
                side = int.Parse(Console.ReadLine());
            } while (side > 9 || side < 2);

            int[] array = new int[side * side];

            int[,] matrix = new int[side, side];

            int sum = 0;

            Console.WriteLine("Please fill in the array");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter element at index {0}", i);
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
            }

            int counter = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[j, i] = array[counter];
                    counter++;
                }
            }


            Console.WriteLine("The matrix looks like:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("The sum of the elements in the matrix is: {0}", sum);
        }
    }
}
