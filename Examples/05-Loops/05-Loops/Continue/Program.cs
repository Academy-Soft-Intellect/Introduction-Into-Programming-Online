using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 15; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            //for (int i = 1; i < 101; i++)
            //{
            //    if (i % 7 == 0 || i % 11 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
        }
    }
}
