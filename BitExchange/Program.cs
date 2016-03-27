namespace BitExchange
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int pos1 = 3;
            long mask1 = 1;
            mask1 = (number >> pos1) & 1;
            int pos2 = 24;
            long mask2 = (number >> pos2) & 1;
            long setZeros = 1 << 21;
            setZeros |= 1;
            setZeros <<= 3;

            // Console.WriteLine(Convert.ToString(setZeros,2));
            number &= ~setZeros;
            number |= mask1 << pos2;
            number |= mask2 << pos1;
            Console.WriteLine(number);
        }
    }
}