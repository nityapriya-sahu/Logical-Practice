using System;

namespace Zoo
{
    public class Birds
    {
        private int leg = 2;
        private int wing = 2;
        private int beak = 1;

        public void chrip()
        {
            Console.WriteLine("Birds is chripping");
        }

        public void run()
        {
            Console.WriteLine("Tiger are flying with " + wing + " wings");
        }
    }
}
