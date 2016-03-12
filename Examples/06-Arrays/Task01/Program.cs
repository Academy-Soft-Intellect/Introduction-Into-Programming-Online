using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ourArray = new int[n];

            for (int i = 0; i < ourArray.Length; i++)
            {
                ourArray[i] = ourArray.Length - i;
            }

            for (int i = 0; i < ourArray.Length; i++)
            {
                Console.WriteLine(ourArray[i]);
            }
        }
    }
}
