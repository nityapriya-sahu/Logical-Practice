using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("ENTER YOUR NUMBER");
            int num = int.Parse(Console.ReadLine());

            int start = 2;

            while (start <= num) 
            {
                Console.WriteLine(start);
                start = start + 2;
                
            }
            Console.ReadLine();*/

            // -------------Using FOR Loop-----------
            Console.WriteLine("ENTER YOUR NUMBER");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i<=num; i++)
            {
                int even = i % 2;
                if (even == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

        }
    }
}
