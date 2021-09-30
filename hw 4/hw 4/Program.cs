using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your no.");
            int num = int.Parse(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine("even num. = " + num);
            }
            else
            {
                Console.WriteLine("odd num. = " + num);
            }
            Console.ReadLine();
        }
    }
}
