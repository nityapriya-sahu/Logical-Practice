using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first no");
            string no1 = Console.ReadLine();
            int a = int.Parse(no1);
            Console.WriteLine("enter second no");
            string no2 = Console.ReadLine();
            int b = int.Parse(no2);
            int sub = a - b;
            Console.WriteLine("total : " + a + "-" + b + "=" + sub); 


        
            Console.ReadLine();
        }
    }
}
