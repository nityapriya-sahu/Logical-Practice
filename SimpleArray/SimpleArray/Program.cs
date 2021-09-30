using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArray (most imp)
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter multiple number with space separation");
            String numbersInString = Console.ReadLine();
            char[] separator = {' '};
            string[] nums = numbersInString.Split(separator);

            for(int i = 0; i<nums.Length; i++)
            {
                int num = int.Parse(nums[i]);
                if (num % 2 != 0)
                {
                    Console.WriteLine("ODD => " + nums[i]);
                }
                else
                {
                    Console.WriteLine("EVEN => "+ nums[i]);
                }
            }
            

            Console.ReadLine();

        }
    }
}
