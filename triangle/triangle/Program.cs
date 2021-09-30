using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a no.");
            int x = int.Parse(Console.ReadLine());

            for (int i = x; x >= 0; i--)
            {
                for (int j = x; j >= i; j++)
                {
                    Console.Write("0");

                }
                Console.WriteLine();
            }
            Console.ReadLine();

            /*Console.WriteLine("enter no.");
            int z = int.Parse(Console.ReadLine());

            for (int i = z - 1; i >= 0; i--)
            {
                for (int j = z - 1; j >= i; j--)
                {
                    Console.Write("0");
                }
                Console.WriteLine();

            }*/

            /* for (int i= 1; i<=z; i++)
             {
                 for (int n = z-i; n>=0; n--)
                 {
                     Console.Write("0");
                 }

                 Console.WriteLine();
             }
             Console.ReadLine();*/
        }
    }
}
