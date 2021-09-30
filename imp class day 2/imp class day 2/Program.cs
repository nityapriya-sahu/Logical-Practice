using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imp_class_day_2
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine("enter your 1st no.");
              int num1 = int.Parse(Console.ReadLine());
              Console.WriteLine("enter your 2nd no.");
              int num2 = int.Parse(Console.ReadLine());

              for (int i = num1; i<=num2; i++)
              {
                  if (i % 2 != 0)
                  {
                      Console.Write(i+",");

                  }
   
              }
            Console.ReadLine();


            /*-----------------------------------------------------*/

            /*Console.WriteLine("enter 1st no.");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd no.");
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i<=num2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("odd number = " + i);

                }
                else 
                    {
                    Console.WriteLine("even number = " + i);

                    }
            }
            Console.ReadLine();*/
        }
    }
}
