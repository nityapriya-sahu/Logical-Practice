using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string s = Console.ReadLine();
            int i = int.Parse(s);

            Calculate(i);
            

            Console.ReadLine();
        }

        private static void Calculate(int inputNum)
        {
            string inputStr = inputNum.ToString();

            char[] inputCharArr = inputStr.ToCharArray();

            int total = 0;

            for (int i =0; i<inputCharArr.Length; i++)
            {
                char c = inputCharArr[i];
                string s  = c.ToString();

                int z = int.Parse(s);
                total = total + z;
            }

            int temp = 10 - total;

            Console.WriteLine(inputNum + "" +temp);
        }
        
    }
}
