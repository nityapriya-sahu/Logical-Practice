using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compare_two_dates
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime sd = new DateTime(1998, 04, 20);
            Console.WriteLine("starting date : = {0}", sd);
            DateTime ed = sd.AddDays(10);
            Console.WriteLine("ending date : = {0}", ed);

            if (sd < ed)
            {
                Console.WriteLine("{0} occurs before {1}", sd, ed);
            }
            Console.ReadLine();
        }
    }
}
