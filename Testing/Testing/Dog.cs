using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Dog : Animal
    {

        public void bark()
        {
            Console.WriteLine("Dog is barkning");
        }

        public void run()
        {
            Console.WriteLine("Dog is running");
        }
    }
}
