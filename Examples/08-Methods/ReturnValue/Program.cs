    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 5;
            int height = 4;

            int sum = CalculateSum(width, height);

            Console.WriteLine(sum);

            //int area = CalculateRectangleArea(width, height);

            //Console.WriteLine("Width " + width + "  Height " + height + " = Area " + area);
            //Console.WriteLine();

        }

        private static int CalculateSum(int width, int height)
        {
            int calculateSum = width + height;

            return calculateSum;
        }

        public static int CalculateRectangleArea(int width, int height)
        {
            int area = width * height;
            return area;
        }
    }
}
