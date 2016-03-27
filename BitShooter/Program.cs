namespace BitShooter
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());
            ulong mask = 0;
            for (int i = 0; i < 3; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int center = int.Parse(input[0]);
                int size = int.Parse(input[1]);
                int endBit = Math.Min(63, center + (size / 2));
                int startBit = Math.Max(0, center - (size / 2));

                // for(int p=startBit;p<=endBit;p++)
                // {
                // mask = mask | (1uL << p);
                // }
                for (int p = startBit; p <= endBit; p++)
                {
                    number = number & ~(1UL << p);
                }

                // Console.WriteLine(Convert.ToString((long)number, 2).PadLeft(64, '0'));
            }

            ulong afterShooting = number & (~mask);
            int countLeft = 0;
            int countRight = 0;
            for (int position = 0; position <= 63; position++)
            {
                ulong currentBit = (number >> position) & 1;
                if (currentBit == 1 && position <= 31)
                {
                    countRight++;
                }
                else if (currentBit == 1 && position > 31)
                {
                    countLeft++;
                }
            }

            Console.WriteLine("left: {0}", countLeft);
            Console.WriteLine("right: {0}", countRight);
        }
    }
}