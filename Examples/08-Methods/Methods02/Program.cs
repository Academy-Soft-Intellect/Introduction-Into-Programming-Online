using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods02
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c = CalculateSum(a, b);
            Console.WriteLine(c);
        }

        private static int CalculateSum(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
    }
}
