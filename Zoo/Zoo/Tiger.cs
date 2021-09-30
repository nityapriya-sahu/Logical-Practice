using System;

namespace Zoo
{
    public class Tiger
    {

        private int leg;
        private int tail;
        private int mouth;

        public void roar()
        {
            Console.WriteLine("Tiger is roaring");
        }

        public void run(int leg)
        {
            Console.WriteLine("Tiger is running with " + leg + " legs");
        }

    }
}