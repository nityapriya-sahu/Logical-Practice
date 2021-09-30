using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leapyr_prac.dlt
{
    class Program
    {
        static int year;
        static void Main(string[] args)
        {
            readData();
            leapYearFinder();
            

            Console.ReadLine();
        }

        private static void readData()
        {
            Console.WriteLine("enter the year");
            year = int.Parse(Console.ReadLine());
        }

        private static void leapYearFinder()
        {
            if (year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine(year + " is the leap year");

            }
            else
            {
                Console.WriteLine(year + " is not a leap year");
            }
        }
    }
}
