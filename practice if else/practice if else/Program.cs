using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            string num = Console.ReadLine();
            int number = int.Parse(num);

            if (number == 10)
            {
                Console.WriteLine("your value is 10");
            }
            else
            {
                Console.WriteLine("your value is not valid");
            }
            Console.ReadLine();
        }
    }
}
