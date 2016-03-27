namespace BitCopy
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            int bit = (number >> position) & 1;
            number &= ~(1 << 2); // setting to zero value of bit on second position;
            number |= bit << 2;
            Console.WriteLine(number);
        }
    }
}