using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter array length:");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            int sum = 0;

            for (int i = 0; i < array.Length; i++)

            {
                Console.WriteLine("Please enter a number for the element at index " + i);
                array[i] = int.Parse(Console.ReadLine());
            }

            foreach (var item in array)
            {
                Console.Write(" |" + item + "| ");
            }
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            {
                Console.WriteLine(sum);
            }
            int side = int.Parse(Console.ReadLine());

            int[,] matrix = new int[side, side];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (side >= 2 && side < 10)
                    {
                        matrix[i, j] = array[i];
                    }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("|" + " " + matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
