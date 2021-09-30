using System;

namespace Zoo
{
    public class Dog
    {
        private int leg;
        private int tail;
        private int mouth;

        public void barks()
        {
            Console.WriteLine("Tiger is roaring");
        }

        public void run(int leg)
        {
            Console.WriteLine("Tiger is running with " + leg + " legs");
        }
    }
}
