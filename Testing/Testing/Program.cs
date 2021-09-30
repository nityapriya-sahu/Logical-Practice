using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.bark();
 
            d.run();


            //=================

             Calculator c = new Calculator();
            int s = c.sum(2,3,4);
            Console.WriteLine("Total = "+s);





            Console.ReadLine();
        }
    }
}
