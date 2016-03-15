using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter array length:");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Please enter a number for the element at index " + i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Your array looks like:");

            Console.WriteLine("With foreach:");
            foreach (var item in array)
            {
                Console.Write(" |" + item + "| ");
            }
            Console.WriteLine();

            Console.WriteLine("With for:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" |" + array[i] + "| ");
            }
            Console.WriteLine();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(" |" + array[i] + "| ");
            }
            Console.WriteLine();
        }
    }
}
