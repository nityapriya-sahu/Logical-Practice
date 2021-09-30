using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patha
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("enter firstnum.");
            string firstnum = Console.ReadLine();
            int c = int.Parse(firstnum);
            Console.WriteLine("enter secondnum");
            string secondnum = Console.ReadLine();
            int N = int.Parse(secondnum);
            int sum = c + N;
            

            Console.WriteLine("total :" +  c +"+" +  N + "=" +sum);
            Console.ReadLine();
            Console.ReadLine();



        }
    }
}
