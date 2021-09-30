using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_specifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            two B = new two();
            B.show();
        }
    }
    class one
    {
        private int x;
        protected int y;
        internal int z;
        public int a;
        protected internal int b;
    }
    class two : one
    {
        public void show()
        {
            Console.WriteLine("Values are : ");
            y = 10;
            z = 20;
            a = 30;
            b = 40;

            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
