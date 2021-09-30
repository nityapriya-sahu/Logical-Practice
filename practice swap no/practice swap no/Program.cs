using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_swap_no
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("Enter First Number");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int y = int.Parse(Console.ReadLine());

            int z = x;
             x = y;
            y = z;

            Console.WriteLine("You entered First Number" + "=" + y);
            Console.WriteLine("You entered  Second Number" + "=" +x);


            Console.WriteLine("After swap First Number" + "=" + x);
            Console.WriteLine("After swap Second Number" + "=" +y);
            Console.ReadLine();*/

            //----------------------------------------------------//

            int i, k;
            Console.WriteLine("Enter two integers \n");
            i = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Before swapping i= {0} and k = {1}", i, k);
            i = i ^ k;
            k = i ^ k;
            i = i ^ k;
            Console.WriteLine("\n After swapping i= {0} and k = {1}", i, k);
            Console.ReadLine();



        }
    }
}
