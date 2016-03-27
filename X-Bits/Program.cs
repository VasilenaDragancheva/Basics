namespace X_Bits
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[8];
            for (int i = 0; i < 8; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int countXBits = 0;
            for (int i = 2; i < 8; i++)
            {
                for (int p = 0; p < 29; p++)
                {
                    bool first = ((numbers[i - 2] >> p) & 7) == 5;
                    bool second = ((numbers[i - 1] >> p) & 7) == 2;
                    bool third = ((numbers[i] >> p) & 7) == 5;
                    if (first & second & third)
                    {
                        countXBits++;
                    }
                }
            }

            Console.WriteLine(countXBits);
        }
    }
}