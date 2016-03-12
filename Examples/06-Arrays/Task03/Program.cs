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
            int length = int.Parse(Console.ReadLine());
            int[] arr1 = new int[length];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }

            int temp = 0;

            for (int i = 0; i < arr1.Length / 2; i++)
            {
                temp = arr1[i];
                arr1[i] = arr1[arr1.Length - 1 - i];
                arr1[arr1.Length - 1 - i] = temp;

                //arr1[i] = arr1[i] + arr1[arr1.Length - 1 - i];
                //arr1[arr1.Length - 1 - i] = arr1[i] - arr1[arr1.Length - 1 - i];
                //arr1[i] = arr1[i] - arr1[arr1.Length - 1 - i];
            }
            Console.WriteLine("Result:");
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }

        }
    }
}
