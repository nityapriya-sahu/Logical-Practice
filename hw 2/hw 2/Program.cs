using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your target");
            int target = int.Parse(Console.ReadLine());

            int start = 1;
            while (start <= target)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
            Console.ReadLine();
        }
    }
}
