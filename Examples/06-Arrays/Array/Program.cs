using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] pencho = new int[] { 3, 6, 12, -7, -1, 2 };

            Console.WriteLine(pencho[6]);

            //Console.WriteLine("Print element at index 4");
            //Console.WriteLine(pencho[4]);

            //Console.WriteLine("Change element at index 2");
            //pencho[2] = 126;

            //Console.WriteLine("Print element at index 2");
            //Console.WriteLine(pencho[2]);

            //Console.Write("Array Length: ");
            //Console.WriteLine(pencho.Length);

            for (int i = 0; i < pencho.Length; i++)
            {
                Console.WriteLine(pencho[i]);
            }


            //string[] ourArray = new string[7];
            //ourArray[0] = "Levski";
            //ourArray[1] = "Roma";
            //ourArray[2] = "Real Madrid";

            //Console.WriteLine(ourArray[4]);
        }
    }
}
