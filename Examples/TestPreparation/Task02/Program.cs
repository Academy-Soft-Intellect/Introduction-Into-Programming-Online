//Да се въведат два масива от N елемeнта - цели числа. Да се изведат всички елементи, които се срещат и в двата масива. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the arrays:");
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("Enter next number for the first array");
                arr1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("Enter next number for the second array");
                arr2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i]==arr2[j])
                    {
                        Console.WriteLine("The number {0} is presented in the both arrays", arr1[i]);
                    }
                }
            }
        }
    }
}
