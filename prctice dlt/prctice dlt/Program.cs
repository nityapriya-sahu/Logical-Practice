using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prctice_dlt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("e no");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("e no2");
            int n2 = int.Parse(Console.ReadLine());
            float div = (float) n1 / (float) n2;
            Console.WriteLine("total = " + div);
            Console.ReadLine();
        }
    }
}
