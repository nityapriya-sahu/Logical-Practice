using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string num = Console.ReadLine();
            int validNum = int.Parse(num);

            switch (validNum)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("You Entered {0}",validNum);
                    break;
                default:
                    Console.WriteLine("Your number is above 30");
                    break;
            }




            Console.ReadLine();


            /*Console.WriteLine("please Enter your age sir.");
            string age = Console.ReadLine();
            int yage = int.Parse(age);

            if (yage >= 1 && yage <= 10)
            {
                Console.WriteLine("your age in between 1 to 10");
            }
            else if (yage >= 11 && yage <= 20)
            {

                Console.WriteLine("Yore age is in between 11 to 20");
            }
            else if (yage >= 21 && yage <= 30)
            {
                Console.WriteLine("your age in between 21 to 30");

            }
            else
            {
                Console.WriteLine("your age not valid");
            }*/
        }
    }
}
