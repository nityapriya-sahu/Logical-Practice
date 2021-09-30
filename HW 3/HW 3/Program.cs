using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your first number");
            int firstnum = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your second number");
            int secondnum = int.Parse(Console.ReadLine());


            for (int i = firstnum+1; i< secondnum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
