namespace Electricity
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int flats = int.Parse(Console.ReadLine());
            DateTime time = DateTime.Parse(Console.ReadLine());
            double lamp = 100.53;
            double comp = 125.9;
            int total = 0;
            int numLamps = 0;
            int numComps = 0;
            if (time.Hour >= 14 && time.Hour <= 18)
            {
                numLamps = 2;
                numComps = 2;
            }
            else if (time.Hour >= 19 && time.Hour <= 23)
            {
                numLamps = 7;
                numComps = 6;
            }
            else if (time.Hour >= 0 && time.Hour <= 8)
            {
                numLamps = 1;
                numComps = 8;
            }
            else
            {
                numLamps = 0;
                numComps = 0;
            }

            total = (int)((numComps * comp + numLamps * lamp) * flats * floors);
            Console.WriteLine("{0} Watts", total);
        }
    }
}