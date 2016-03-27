namespace BitExchangeSequence
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            long mask = (1 << 3) - 1;
            long firstBits = (number >> 3) & mask;
            long secondBits = (number >> 24) & mask;

            number &= ~(mask << 3);
            number &= ~(mask << 24);
            number |= secondBits << 3;
            number |= firstBits << 24;
            Console.WriteLine(number);
        }
    }
}