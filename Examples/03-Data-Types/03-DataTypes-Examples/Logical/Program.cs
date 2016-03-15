using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 5;
            //int y = 6;

            ////Console.WriteLine(x <= y);

            //bool a = x > y;
            //Console.WriteLine(!a);
            //bool b = true;
            //Console.WriteLine(!b);

            bool x = true;
            bool y = false;

            Console.WriteLine(x && y); //false
            Console.WriteLine(x || y); // true
            Console.WriteLine(x ^ y); // true
            Console.WriteLine(!x); //false
            Console.WriteLine(!y); //true

        }
    }
}
