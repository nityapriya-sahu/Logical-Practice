using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abc



{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            string num = Console.ReadLine();

            Char[] numArr = num.ToCharArray();
            //StringBuilder sb = new StringBuilder();

            string s = "";


            for (int i = (numArr.Length-1); i >= 0; i--)
            {
                s = s+numArr[i].ToString();
            }

            Console.WriteLine("value : " + s);

            Console.ReadLine();
             
        }
    }
}
