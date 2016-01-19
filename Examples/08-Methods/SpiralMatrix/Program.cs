﻿using System;

namespace SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main()
        {
            Console.Write("Enter the size of the matrix: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            Console.WriteLine();

            string direction = "right";
            int row = 0;
            int col = 0;

            for (int i = 1; i <= n * n; i++)
            {
                if (direction == "right" && (col >= n || matrix[row, col] != 0))
                {
                    col--;
                    row++;
                    direction = "down";
                }
                else if (direction == "down" && (row >= n || matrix[row, col] != 0))
                {
                    row--;
                    col--;
                    direction = "left";
                }
                else if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                {
                    row--;
                    col++;
                    direction = "up";
                }
                else if (direction == "up" && (row < 0 || matrix[row, col] != 0))
                {
                    row++;
                    col++;
                    direction = "right";
                }

                matrix[row, col] = i;

                if (direction == "right")
                {
                    col++;
                }
                else if (direction == "down")
                {
                    row++;
                }
                else if (direction == "left")
                {
                    col--;
                }
                else if (direction == "up")
                {
                    row--;
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,4}", matrix[i, j]);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}