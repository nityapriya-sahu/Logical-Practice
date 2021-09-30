using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Employee
    {
        public Employee()
        {
            Console.WriteLine("================= WHO IS A GOOD EMPLOYEE ==================");
        }

        public Employee(String name)
        {
            Console.WriteLine("================= "+name+" IS A GOOD EMPLOYEE ==================");
        }

        public void empName()
        {
            //Console.WriteLine("Emp Name = CHINTU");
        }


    }
}
