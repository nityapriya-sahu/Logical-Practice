using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your target ?");
            int targetnumber = int.Parse (Console.ReadLine());
            int start = 2;

            do
            {
                Console.WriteLine("your numbers are =" + start);
                start = start + 2;

            }
            while (start <= targetnumber);
            
            Console.ReadLine();
        }
    }
}
