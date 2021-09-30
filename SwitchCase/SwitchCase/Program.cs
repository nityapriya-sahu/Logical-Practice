using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalCoffeeCost = 0;
            
            Start:
            Console.WriteLine("1 - Small, 2 - Medium, 3 - Large");
            int chooenValue = int.Parse(Console.ReadLine());

            switch (chooenValue)
            {
                case 1:
                    totalCoffeeCost +=  1;
                    break;
                case 2:
                    totalCoffeeCost = totalCoffeeCost + 2;
                    break;
                case 3:
                    totalCoffeeCost = totalCoffeeCost + 3;
                    break;
                default:
                    Console.WriteLine("you entered invalid input");
                    break;

            }
            Console.WriteLine("billing amount = "+ totalCoffeeCost);
            Console.WriteLine("do you want another one ? (yes/no)");
            string ok = Console.ReadLine();
            switch (ok)
            {
                case "yes":
                    goto Start;
                case "no":
                    break;
                default:
                    Console.WriteLine("thank you shopping with us");
                    break;
                    
            }


            Console.ReadLine();
        }
    }
}
