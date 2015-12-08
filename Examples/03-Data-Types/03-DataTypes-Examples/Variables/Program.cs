using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int testInt = 4;

            short a = -256;
            ushort b = 3;

            byte positiveByte = 200;

            sbyte negativeByte = -20;
            Console.WriteLine(testInt);

            int lazar = 5 + testInt;
            Console.WriteLine(lazar);

            testInt = 30;
            Console.WriteLine(testInt);

            //ТИП   Име                 стойност
            double floatingPointNumber = 4;
            Console.WriteLine(floatingPointNumber);

            float floatingPoint = 5.6f;

            decimal decimalValue = 6.8m;

            bool isTrue = false;
            Console.WriteLine(isTrue);

            char oneSymbol = 'g';
            Console.WriteLine(oneSymbol);
        }
    }
}
