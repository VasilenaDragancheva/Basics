namespace BitFlipper
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());
            int position = 62;
            ulong mask = 7;
            while (position > 0)
            {
                position--;
                ulong currentBits = (number >> position) & mask;
                if (currentBits == 0 || currentBits == 7)
                {
                    number = number ^ (7UL << position);
                    position -= 2;
                }
            }

            Console.WriteLine(number);
        }
    }
}