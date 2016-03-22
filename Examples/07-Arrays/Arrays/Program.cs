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
            int[,] arr = new int[10, 10];

            int[,] arr2 = new int[,] { { 1, 2 }, { 1, 2 }, { 1, 2 } };

            int[] arr3 = new int[5];

            Console.WriteLine(arr3.Length);
        }
    }
}
