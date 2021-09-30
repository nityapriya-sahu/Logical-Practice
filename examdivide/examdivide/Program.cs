using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examdivide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER NO");
            string no1 = Console.ReadLine();
            int a =  int.Parse(no1);
            Console.WriteLine("ENTER AU GOTE NO");
            string no2 = Console.ReadLine();
            int b = int.Parse(no2);
            double div = (double)a / (double)b;

            Console.WriteLine("CONCLUSION : " + a + "/" + b + "=" + div);
            Console.ReadLine();
        }
    }
}
