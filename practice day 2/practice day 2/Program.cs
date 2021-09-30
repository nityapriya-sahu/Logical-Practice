using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_day_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your name");
            string yname = Console.ReadLine();
            Console.WriteLine("please enter your surname");
            string sname = Console.ReadLine();

            string name = "please wait.. or press enter";
            Console.WriteLine(name);
            Console.ReadLine();
            Console.WriteLine("YOUR NAME :" + yname + "_" + sname);
            //Console.ReadLine();
            Console.WriteLine("please enter your 10th mark");
            string mark = Console.ReadLine();
            //int i;
            //string []a;

            float value = float.Parse(mark);
            //Console.ReadLine();
            double div = value/600.00;
            Console.WriteLine("total :" + value+ "/"+"600 " + "=" + (div*100) +"%");
            Console.ReadLine();


        }
    }
}
