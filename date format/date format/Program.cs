using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date_format
{
    class Program
    {
        static void Main(string[] args)
        {
           
            DateTime date = new DateTime(2021, 07, 10);
            Console.WriteLine("various formats are : {0} " , date);
            Console.WriteLine(date.ToString("dd/MM/yyyy"));
            Console.WriteLine(date.ToString("MM/dd/yyyy"));
            Console.WriteLine(date.ToString("yyyy/dd/MM"));
            Console.ReadLine();



           
        }
        
    }
}
