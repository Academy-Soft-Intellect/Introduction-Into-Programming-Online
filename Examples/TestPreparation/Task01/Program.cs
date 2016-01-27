//Даден е масив с 10 елемента. Да се намери максималния измежду елементите с четен индекс и минималния измежду елементите с нечетен индекс. 

using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            int min = Int32.MaxValue;
            int max = Int32.MinValue;

            Console.WriteLine("Please fill in the array!");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter next number");
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                }
                else
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                }
            }

            Console.WriteLine("The max number between the ones on EVEN indexes is:", max);
            Console.WriteLine("The min number between the ones on ODD indexes is:", min);
        }
    }
}
