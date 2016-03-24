using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix4x4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[2, 2];

            PrintArray(matrix);

            matrix = GenerateMatrix(matrix);

            PrintArray(matrix);

            Console.WriteLine();

            matrix = ModifyMatrix(matrix);

            PrintArray(matrix);
        }

        private static int[,] ModifyMatrix(int[,] modifiedMatrix)
        {
            Console.WriteLine("Modifing matrix...");
            for (int i = 0; i < modifiedMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < modifiedMatrix.GetLength(1); j++)
                {
                    if (modifiedMatrix[i, j] % 2 == 1)
                    {
                        modifiedMatrix[i, j] *= 2;
                    }
                }
            }

            return modifiedMatrix;
        }

        private static int[,] GenerateMatrix(int[,] matrixToBeGenerated)
        {
            Console.WriteLine("Generating matrix...");
            for (int i = 0; i < matrixToBeGenerated.GetLength(0); i++)
            {
                for (int j = 0; j < matrixToBeGenerated.GetLength(1); j++)
                {
                    matrixToBeGenerated[i, j] = int.Parse(Console.ReadLine());
                }
            }

            return matrixToBeGenerated;
        }

        private static void PrintArray(int[,] arrayToPrint)
        {
            for (int i = 0; i < arrayToPrint.GetLength(0); i++)
            {
                for (int j = 0; j < arrayToPrint.GetLength(1); j++)
                {
                    Console.Write("   " + arrayToPrint[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
