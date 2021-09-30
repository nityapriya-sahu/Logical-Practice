using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY_EXERCISE
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] arr = new int[10];
            Console.WriteLine("Enter 10 Number");
            // Store Value to array
            for (int k=0; k<10; k++)        //Assign => Condition => Increment/decrement 
            {
                String str = Console.ReadLine();
                int num = Convert.ToInt32(str);
                arr[k] = num;
            }
            //Print Array
            

            for (int j=0; j<10; j++)
            {
                Console.Write(arr[j]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("REVERSE ORDER");
            for (int j=9; j>=0;j--)
            {
                Console.Write(arr[j] + " ");
            }
            
            // Pause Console
            Console.ReadLine();*/

            //my practice....

            /*int[] arr = new int[10];
            Console.WriteLine("enter the number : ");

            for(int i = 0; i < 10; i++)
            {
                Console.Write("number{0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int j = 0; j < 10; j++)
            {
                Console.Write(arr[j] + ", ");
            }
            Console.ReadLine();*/

            //correct----------------------------------------------------

            int[] arr = new int[5];
            Console.Write("enter the five numbers: \n");

            for(int i= 0; i < 5; i++)
            {
                Console.Write("Number {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("the numbers are : \n");
             for(int j = 0; j < 5; j++)
            {
                Console.Write(arr[j]+ " ");
            }
            Console.ReadLine();

            Console.WriteLine("\nthe array in reverse is : \n");
            for(int j = 4; j >= 0; j--)
            {
                Console.Write(arr[j] + " ");
            }
            Console.ReadLine();
        }
    }
}
