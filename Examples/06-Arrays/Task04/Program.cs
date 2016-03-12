using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] arr1 = new int[length];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }

            bool isSymetric = true;

            for (int i = 0; i < arr1.Length / 2; i++)
            {
                if (arr1[i] != arr1[arr1.Length - 1 - i])
                {
                    isSymetric = false;
                    break;
                }
            }
            Console.WriteLine("The array is symetric: " + isSymetric);
        }
    }
}
