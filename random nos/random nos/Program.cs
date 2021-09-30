using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_nos
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("some generated random nos. are :");
            int i = int.Parse(Console.ReadLine());
            for (i = 1; i<10; i++)
            {
                int n = r.Next();
                Console.WriteLine(n);
                Console.ReadLine();
            }
        }
       
    }
}
