using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leap_year
{
    class leapyear
    {
        static void Main(string[] args)
        {
            
            readdata();
            

            leap();
        }
        static int y;
        public static void readdata()
        {
            Console.WriteLine("Enter the Year in Four Digits : ");
            y = int.Parse(Console.ReadLine());
        }
        public static void leap()
        {
            if (y % 4 == 0)
            {
                Console.WriteLine("{0} is a Leap Year", y);
            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year", y);
            }
            Console.ReadLine();
        }
    }
}
