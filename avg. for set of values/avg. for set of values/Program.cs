using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avg.for_set_of_values
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("enter the no. of array :\n");
            int m = int.Parse(Console.ReadLine());
            int[] a = new int[m];
           Console.WriteLine("enter the array elements :\n");
             
            for(int i = 0; i < m; i++)
            {
                 a[i] = int.Parse(Console.ReadLine());
                //Console.WriteLine("====== " + a.ToString() + " ==========");
            
            }
            for(int i = 0; i < m; i++)
            {
                  sum = sum + a[i];
            }
            int avg = sum / m;
            Console.WriteLine("The avg value is :{0}", avg);
            Console.ReadLine();
            
            
        }
    }
}
