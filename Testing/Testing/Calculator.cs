using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Calculator
    {
        public int sum(int a, int b)
        {
            int c = a + b;
            return c;
            
        }
        public int sum(int a, int b, int c)
        {
            int d = a + b + c;
            return d;

        }
        public int sub(int a, int b)
        {
            int c = a - b;
            return c;

        }
        public int mul(int a, int b)
        {
            int c = a * b;
            return c;

        }

    }
}
