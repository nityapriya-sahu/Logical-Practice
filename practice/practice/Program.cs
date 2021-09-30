using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter  the no.");
            string num = Console.ReadLine();

            char[] c = num.ToCharArray();
            string s = "";


            for (int i = c.Length-1; i>=0; i--)
            {
                s = s + c[i].ToString();

            }
            Console.WriteLine("new no. is : " + s);
            Console.ReadLine();
        }
    }
}
