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

            int[] a = new int[6];

            string[] b = new string[10];

            //a[0] = int.Parse(Console.ReadLine());
            //a[1] = 3;
            //a[2] = 5;
            //a[3] = 3;
            //a[4] = 5;
            //a[5] = 3;

            //Console.WriteLine(a[1]);
            //Console.WriteLine(a[0]);

            ////Console.WriteLine(a.Length);

            ////Console.WriteLine(a[3]);

            for (int i = 0; i < 6; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            //int[] pencho = new int[] { 3, 6, 12, -7, -3 };

            ////Console.WriteLine(pencho[5]);
            //for (int i = 0; i < pencho.Length; i++)
            //{
            //    Console.Write("|" + pencho[i] + "| ");
            //}
            //Console.WriteLine();
            //Console.WriteLine(pencho.Length);

        }
    }
}
