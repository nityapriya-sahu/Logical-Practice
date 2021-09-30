using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.Write(": Display the natural numbers :\n");
             Console.Write("-------------------------------\n");

             for(int i = 0; i <= 20; i++)
             {
                 Console.Write(" " +i);
             }*/

            //correct-------------------=-----------------------
            /* int i, sum = 0;
             Console.Write(": first 20 natural numbers are :\n");
             for( i = 0; i <= 20; i++)
             {
                 sum = sum + i;
                 Console.Write(",{0} ", i);
             }
             Console.Write("\n\n");
             Console.WriteLine("The sum is : {0}\n", sum);*/

            //correct---but my fault on sum--------------------

            /* int sum = 0;
             Console.WriteLine("enter a number to know that their sum value\n");
             int n = int.Parse(Console.ReadLine());

             Console.Write("the first {0} natural nos. are :", n);
             for(int i = 0; i <= n; i++)
             {
                 sum = sum + i;
                 Console.Write(","+i); 
             }
             Console.Write("\n\n");
             Console.Write("the sum is: {0}", sum);*/

            //correct--------------------------------------------------
            /* int sum = 0;
             Console.Write("Input the 10 numbers :\n");
             for(int i = 1;i <= 10; i++)
             {
                 Console.Write("Number {0}: ", i);
                 int n = int.Parse(Console.ReadLine());
                 sum = sum + n;
             }
             Console.Write("the sum of 10 no. is : {0}\n", sum);
             double avg = sum / 10.0;
             Console.Write("the average value is : {0}\n", avg);*/

            //correct--------------------------------------------------

            /* int cube = 0;
             Console.Write("Input the number : \n");
             int n = int.Parse(Console.ReadLine());

             for (int i = 1; i <= n; i++)
             {
                 cube = i * i * i;
                 Console.Write("{0} cube: {1} \n", i, cube);
             }*/

            //correct---------------------------------------------------
            /* int nos = 0;
             Console.WriteLine("Input a number(table to be calculated) :");
             int t = int.Parse(Console.ReadLine());

             for (int i = 1; i <= 10; i++)
             {
                 nos = t * i;
                 Console.Write("table is : {0} * {1} = {2}\n",t ,i,nos);
             }*/

            //correct-----------------------------------------------------

            /*int nos = 0;
            Console.WriteLine("input the number of terms :");
            int num = int.Parse(Console.ReadLine());

            Console.Write("the odd numbers are : \n");
            for (int i = 1; i <= num; i++)
            {

                int x = i * 2 - 1;
                Console.Write(" {0}\n", x);
                nos = nos + x;
            }
            Console.Write("the sum of their numbers are : {0}\n", nos);*/

            //correct-------------------------------------------------------------

            /* Console.WriteLine("enter the no. of rows :\n");
             int r = int.Parse(Console.ReadLine());

             for(int i = 1; i <= r; i++)
             {
                 Console.Write(" \n");
                 for(int j = 1; j <= i; j++)
                 {
                     Console.Write("* ");
                 }
             }*/

            //correct-----------------------------------------------------------

            /* Console.Write("enter the no. of rows : \n");
             int x = int.Parse(Console.ReadLine());

             for(int i = 1; i<=x; i++)
             {
                 Console.Write(" \n");
                 for(int j = 1; j <= i; j++)
                 {
                     Console.Write("{0} ", j);
                 }
             }*/

            //correct--------------------------------------------------------------

            /* Console.Write("display the right angle triangle increased by 1 \n");
             Console.Write("-------------------------------------------------- \n");
             int k = 1;
             Console.Write("enter the no. of rows :");
             int r = int.Parse(Console.ReadLine());

             for (int i = 1; i <= r; i++)
             {
                 Console.Write(" \n");
                 for(int j = 1; j <= i; j++)
                 {
                     Console.Write(" {0}",k++);
                 }
             }*/

            //correct----------------------------------------------------------------


            /* Console.Write("draw a pyramid increased by 1\n");
             Console.Write("-------------------------------\n");
             Console.Write("enter the no. of terms :");
             int p = int.Parse(Console.ReadLine());

             int count = 1;
             count = p - 1;
             for (int k = 1; k <= p; k++)
             {
                 for (int i = 1; i <= count; i++)
                 {
                     Console.Write(" ");
                 }
                 count--;
                 for (int i = 1; i <= 2 * k - 1; i++)
                 {
                     Console.Write("*");
                 }
                 Console.WriteLine();
             }*/

            //correct---------------------------------------------------------

            int i, j, spc, rows, k;

            Console.Write("\n\n");
            Console.Write("Display the pattern like pyramid with asterisk:\n");
            Console.Write("-------------------------------------------------");
            Console.Write("\n\n");

            Console.WriteLine("enter the no. of rows : ");
            rows = int.Parse(Console.ReadLine());
            spc = rows + 4 - 1;

            for(k = 1; k <= rows; k++)
            {
                for (i = spc; i >= 1; i--)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= k; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
                spc--;
            }


                //correct------------imp. for me ------------------------------ 

                /* int factor = 1;
                     Console.Write("calculate the factorial of given no. :\n");
                     Console.Write("-------------------------------------- \n");

                     Console.Write("please enter a number :\n");
                     int num = int.Parse(Console.ReadLine());

                     for(int i = 1; i <= num; i++)
                 {
                     factor = factor * i;

                 }
                 Console.Write("the factorial of {0} is = {1} \n", num, factor);*/

                //correct-------------------------------------------------------------------

                /* int sum = 0; 
                 Console.Write("display the sum of even numbers :\n");
                 Console.Write("----------------------------------\n");

                 Console.Write("enter the no. of terms :");
                 int num = int.Parse(Console.ReadLine());

                 Console.Write("the even numbers are :\n");
                 for (int i = 1; i <= num; i++)
                 {
                    int x = 2 * i;
                     sum = sum + x;
                     Console.Write(" {0}\n", x);
                 }

                 Console.Write("the sum of such even numbers is : {0} \n", sum);*/

                //correct----------------------------------------------------------------


            //----** IF ANY PROBLEM SEARCH "W3RESOURCE" FROM GOOGLE **----\\
            
        }
    }
}

    

