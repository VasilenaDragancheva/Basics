namespace BitKiller1
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int index = 0;
            int bitCounter = 0;
            int number = 0;
            int[] inputs = new int[n];
            for (int i = 0; i < n; i++)
            {
                inputs[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                int input = inputs[i];

                for (int bit = 7; bit >= 0; bit--)
                {
                    if (index % step != 1 && step != 1)
                    {
                        number <<= 1;
                        number |= (input >> bit) & 1;
                        bitCounter++;
                        if (bitCounter == 8)
                        {
                            Console.WriteLine(number);
                            bitCounter = 0;
                            number = 0;
                        }
                    }

                    index++;
                }
            }

            if (bitCounter > 0)
            {
                number <<= 7 - bitCounter + 1;
                Console.WriteLine(number);
            }

            if (step == 1)
            {
                Console.WriteLine((inputs[0] >> 7) << 7);
            }
        }
    }
}