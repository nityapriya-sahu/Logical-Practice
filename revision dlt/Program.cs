using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revision_dlt
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("enter the 1st no.");
             int x = int.Parse(Console.ReadLine());

             Console.WriteLine("enter the 2nd no.");
             int y = int.Parse(Console.ReadLine());

             int z = x + y;

             Console.WriteLine("value = " + x + "+" + y + "=" + z);
             Console.ReadLine();*/

            //----------------------------------------//

            /* Console.WriteLine("Enter a number");
             int num = int.Parse(Console.ReadLine());

             switch (num)
             {
                 case 10:
                     Console.WriteLine("it is 10");
                     break;
                 case 20:
                     Console.WriteLine("it is 20");
                     break;
                 default: Console.WriteLine("it is not 10 and 20");
                     break; 
             }*/
            //----------------------------------------------------//

            //--- if else-----//

           /* Console.WriteLine("enter the 1st no.\n");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the 2nd no.\n");
            int y = int.Parse(Console.ReadLine());

            if (x == y)
            {
                Console.WriteLine(x + " and " + y + " are equal.");
            }
            else { Console.WriteLine("these are not equal."); }

            //correct----------------------------------

            Console.WriteLine("please enter the the no.\n");
            int z = int.Parse(Console.ReadLine());
            
            if(z % 2 == 0)
            {
                Console.WriteLine(z + " is a even number");
            }else
            {
                Console.WriteLine(z + " is a odd number");
            }*/

            //correct------------------------------------------

           /* Console.WriteLine("enter a no. please");
            int xx = int.Parse(Console.ReadLine());

            if (xx >= 0) { Console.WriteLine("it is a positive number"); } else
            {
                Console.WriteLine("it is a negative number");
            }*/

            //correct-----------------------------------

            Console.WriteLine("enter a year ");
            int A = int.Parse(Console.ReadLine());

            if (A % 4 == 0  && A % 100 != 0)
            {
                Console.WriteLine("this is a leap year");
            }
            else { Console.WriteLine("this is not a leap year"); }
          
        }
    }
}
