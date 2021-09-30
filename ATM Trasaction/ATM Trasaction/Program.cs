using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Trasaction
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = 2000;
            Console.WriteLine("PLEASE ENTER YOUR PIN");
            int pin = int.Parse(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("----------WLC TO ATM SERVICE----------\n");
                Console.WriteLine("1: Check balance\n");
                Console.WriteLine("2: Withdraw cash\n");
                Console.WriteLine("3: Deposit cash\n");
                Console.WriteLine("4: Cancel \n\n");
                Console.WriteLine("Please enter your choice");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Your balance is = RS: {0}",  amount);
                        break;
                        case 2:
                        Console.WriteLine("Please enter the amount to withdraw : ");
                        int withdraw = int.Parse(Console.ReadLine());
                        if(withdraw % 100 != 0)
                        {
                            Console.WriteLine("\nPlease enter the amount multiple of 100");
                        }else if(withdraw > amount)
                        {
                            Console.WriteLine("INSUFFICENT BALANCE\n");
                        }
                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("PLEASE COLLECT CASH\n\n");
                            Console.WriteLine("\nYOUR BALANCE IS : Rs = {0}", amount);
                        }break;
                    case 3:
                        Console.WriteLine("Please enter the amount to deposit:");
                        int deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("\nYour balance is : Rs = {0}", amount);
                        break;
                    case 4:
                        Console.WriteLine("******THANK YOU VISIT AGAIN******\n");
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input");
                        break;
                }

            }
           
        }
    }
}
