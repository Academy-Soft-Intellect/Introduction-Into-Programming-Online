using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            while (counter <= 20)
            {
                if (counter % 2 != 0)
                {
                    Console.WriteLine(counter);
                }
                counter++;
            }
            Console.WriteLine("Loop ended!");
        }
    }
}
