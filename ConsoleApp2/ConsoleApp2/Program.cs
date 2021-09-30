using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            long val = 5;
            for (int i = 0; i<=val; i++)
            {
                val += i;
                Console.WriteLine("NEULA => " + i);

            }
        }
    }
}
