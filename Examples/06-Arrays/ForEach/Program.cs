using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = new string[] { "We", "Are", "The", "Champions" };

            foreach (var item in stringArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
