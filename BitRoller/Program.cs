namespace BitRoller
{
    using System;

    class Program
    {
        const int SIZE = 19;

        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            int frozenPosition = int.Parse(Console.ReadLine());
            int rollingTimes = int.Parse(Console.ReadLine());
            for (int i = 0; i < rollingTimes; i++)
            {
                number = RollingOnce(number, frozenPosition);
            }

            Console.WriteLine(number);
        }

        static uint RollingOnce(uint number, int frozenPosition)
        {
            uint result = 0;
            for (int pos = 0; pos < SIZE; pos++)
            {
                uint currentBit = (number >> pos) & 1;

                if (pos == frozenPosition)
                {
                    result |= currentBit << pos;
                }
                else
                {
                    int newpos = NewPosition(pos);
                    if (newpos == frozenPosition)
                    {
                        newpos = NewPosition(newpos);
                    }

                    result |= currentBit << newpos;
                }
            }

            return result;
        }

        static int NewPosition(int pos)
        {
            int newpos = pos - 1;
            if (newpos < 0)
            {
                newpos = SIZE - 1;
            }

            return newpos;
        }
    }
}