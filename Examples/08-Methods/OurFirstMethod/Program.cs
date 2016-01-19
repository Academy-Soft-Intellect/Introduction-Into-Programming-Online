using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurFirstMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "My name";
            string yourName = "Your name";
            PrintNames(name, yourName);
            //PrintName(name);

            int b = 5;
            int[] a = new int[5];
            ChangeNumberValue(a, out b);
            Console.WriteLine(b);
            //PrintName(yourName);
            //PrintNameXTimes(yourName, 5);
            ////Console.WriteLine();
            ////Console.WriteLine("Waiting....");
            ////Console.WriteLine();
            ////string secondName = "Your name";
            ////PrintMyName(secondName);
        }
        static void ChangeNumberValue(int[] ar, out int param2)
        {
            ar[2] = 5;
            param2 = 10;
        }

        private static void PrintNameXTimes(string stringParam, int numberParam)
        {
            for (int i = 0; i < numberParam; i++)
            {
                Console.WriteLine(stringParam);
            }
        }

        private static void PrintNames(string param1, string param2)
        {
            Console.WriteLine(param1);
            Console.WriteLine(param2);
        }

        private static void PrintName(string param1)
        {
            Console.WriteLine(param1);
        }

        






    }
}
