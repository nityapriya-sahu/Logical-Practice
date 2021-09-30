using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace only_imp_task
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("enter your 1st no");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter your 2nd no");
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                if (i%2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();*/

            Console.WriteLine("enter the no");
            int num1 = int.Parse(Console.ReadLine());

           /* for (int i = 1; i<= num1; i++)
            {
                for (int j = 1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/
            for (int k = num1-1; k == 0 ; k--)
            {
                for (int m = num1-1; m <= k; m--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
