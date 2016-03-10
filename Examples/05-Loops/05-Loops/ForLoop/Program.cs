using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        private static void Main(string[] args)
        {
            //for (int i = 2; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            int counter = 0;

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.WriteLine("I = {0}, J = {1}, counter = {2}", i, j, counter);
                    counter++;
                }
            }

            //int n = 6;

            //long factorial = 1;

            //for (int i = 1; i <= n; i++)
            //{
            //    factorial *= i;
            //}

            //Console.WriteLine("{0}! = {1}", n, factorial);
        }
    }
}
