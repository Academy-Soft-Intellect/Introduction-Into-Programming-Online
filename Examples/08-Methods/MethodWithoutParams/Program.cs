using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodWithoutParams
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello();
            Console.WriteLine("Method 1");
            SayGoodBye();
            Console.WriteLine("Method 2");
            SayHello();
        }

        private static void SayGoodBye()
        {
            Console.WriteLine("GoodBye");
        }

        public static void SayHello()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("My name");
        }
    }
}
