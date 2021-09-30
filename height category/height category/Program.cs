using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace height_category
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your height (in cm.) :\n ");
            int height = int.Parse(Console.ReadLine());
            if (height <= 195 && height >=  165)
            {
                Console.WriteLine("HEIGHT = TALLER\n");
            }
            else if(height < 165 && height >= 150)
            {
                Console.WriteLine("HEIGHT = AVERAGE\n");

            }else if (height < 150 && height > 100)
            {
                Console.WriteLine("HEIGHT =  DWARF\n");
            }
            else
            {
                Console.WriteLine("ABNORMAL HEIGHT\n");
            }
            Console.ReadLine();
        }
    }
}
