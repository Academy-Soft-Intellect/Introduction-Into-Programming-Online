using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine(gosho[3]);
            //Console.WriteLine(gosho[0]);
            //Console.WriteLine(gosho[1]);
            //Console.WriteLine(gosho[2]);
            //Console.WriteLine(gosho.Length);

            string[] gosho = new string[] { "We", "Are", "The", "Champions" };

            foreach (var item in gosho)
            {
                Console.WriteLine(item);
            }
        }
    }
}
