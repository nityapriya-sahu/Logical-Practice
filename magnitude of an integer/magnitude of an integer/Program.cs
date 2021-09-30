using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magnitude_of_an_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, mag = 0;
            Console.WriteLine("Enter the Number : ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Number: " + num);
            while (num > 0)
            {
                mag++;
                num = num / 10;
            }
            Console.WriteLine("Magnitude: " + mag);
            Console.Read();
        }
    }
}
