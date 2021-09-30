using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested_loop_prac
{
    class Program
    {
        static void Main([] args)
        {string
            Console.WriteLine("Enter the no. of rows :");
            int num = int.Parse(Console.ReadLine());

            int count = num - 1;

            for(int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= count; j++)
                {
                    Console.Write(" ");
                }
                count--;
                for (int j = 1; j <= i * 2 - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            count = 1;
            for(int i = 1; i <= num - 1; i++)
            {
                for (int j = 1; j <= count; j++)
                {
                    Console.Write(" ");
                }
                count++;
                for (int j = 1; j <=2 *( num - i)- 1; j++)
                {
                    Console.Write("0");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
        
    }
}
