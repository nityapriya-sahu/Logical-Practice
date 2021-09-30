using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] member = new string[4];

            member[0] = "chintu";
            member[2] = "mantu";
            member[3] = "dola";
            member[1] = "chikun";

            /*for (int i = 0; i < member.Length; i++)
            {
                Console.WriteLine(member[i]);
            }*/

            foreach (string m in member)
            {
                Console.WriteLine(m);
            }

            Console.ReadLine();
        }
    }
}
