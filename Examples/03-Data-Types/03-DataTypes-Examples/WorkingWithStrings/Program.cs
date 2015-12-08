using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Ivaylo Babalev";
            string result = "Hello " + name + "!";
            Console.WriteLine(result);

            Console.WriteLine(result[1]);
        }
    }
}
