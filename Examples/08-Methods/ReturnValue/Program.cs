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

            int area = CalculateRectangleArea(width, height);

            Console.WriteLine("Width " + width + "  Height " + height + " = Area " + area);
            Console.WriteLine();

        }

        public static int CalculateRectangleArea(int width, int height)
        {
            int area = width * height;
            return area;
        }
    }
}
