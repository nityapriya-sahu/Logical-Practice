using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examgunana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st no.");
            string a = Console.ReadLine();
            int A = int.Parse(a);
            Console.WriteLine("enter 2nd no.");
            string b = Console.ReadLine();
            int B = int.Parse(b);
            int Mul = A * B;

            Console.WriteLine("total : " + A + "*" + B + "=" + Mul);
            Console.ReadLine();


        }
    }
}
