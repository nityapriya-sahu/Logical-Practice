using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your First Name");
            string fname = Console.ReadLine();

            Console.WriteLine("Enter Your Last Name");
            string lname = Console.ReadLine();

            Console.WriteLine("Are you Student");
            string std = Console.ReadLine();

            bool? b = null;

            if (b != null)
            {
                bool b1 = bool.Parse(std);


                if (b1)
                {
                    Console.WriteLine("Bahut Badhia");
                }
                else
                {
                    Console.WriteLine("Murkha");
                }
            }
            else
            {
                Console.WriteLine("GALUA");
            }
            

            Console.ReadLine();
        }
    }
}
