using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grade_nd_display
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your grade in upper case\n");
            string grade = Console.ReadLine();
            Console.WriteLine();

            switch (grade)
            {
                case "O":
                    Console.WriteLine("EXCELLENT\n");
                    break;
                case "S":
                    Console.WriteLine("SUPER\n");
                    break;
                case "A":
                    Console.WriteLine("VERY GOOD\n");
                    break;
                case "B":
                    Console.WriteLine("GOOD\n");
                    break;
                case "C":
                    Console.WriteLine("AVERAGE\n");
                    break;
                case "D":
                    Console.WriteLine("BELOW\n");
                    break;
                case "E":
                    Console.WriteLine("BETTER LUCK NEXT TIME\n");
                    break;
                case "F":
                    Console.WriteLine("FAIL\n");
                    break;
                default :
                    Console.WriteLine("INVALID INPUT");
                    break;
            }
        }
    }
}
