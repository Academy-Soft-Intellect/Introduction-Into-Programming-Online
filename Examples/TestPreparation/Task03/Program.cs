//Имате двумерен масив от естествени числа от интервала [0..100]. Да се състави програма, чрез която се извеждат елементите от масива с най-малката и най-голямата стойност.

using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the side of the matrix:");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n,n];
            int min = Int32.MaxValue;
            int max = Int32.MinValue;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int nextNumber = int.Parse(Console.ReadLine());
                    while (nextNumber<1 && nextNumber>100)
                    {
                        Console.WriteLine("Please enter a number between 1 and 100");
                        nextNumber = int.Parse(Console.ReadLine());
                    }
                    matrix[i, j] = int.Parse(Console.ReadLine());
                    if (matrix[i,j] > max)
                    {
                        max = matrix[i, j];
                    }
                    if (matrix[i, j]<min)
                    {
                        min = matrix[i, j];
                    }
                }
            }

            Console.WriteLine("The biggest number in the matrix is:", max);
            Console.WriteLine("The smallest number in the matrix is:", min);
        }
    }
}
